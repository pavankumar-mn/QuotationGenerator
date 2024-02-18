using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using IronPdf;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public partial class Quotation : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();
        public Quotation()
        {
            InitializeComponent();
            ///
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            ///
            
        } 

        public void LoadQuoteNumber()
        {
            string bModel;
            if (!String.IsNullOrEmpty(Home.Model))
                bModel = Home.Model;
            else
                bModel = Home.Brand;
            string quoteNumber = "SE/" + Home.Place + "/" + DateTime.Now.Year.ToString() + "/" + bModel + "-" + 1;
            tblQuotatiomNo.Controls.Add(new Label() { Text = "Quotation Number" }, 0, 0);
            tblQuotatiomNo.Controls.Add(new Label() { Text = "Date" }, 0, 1);
            tblQuotatiomNo.Controls.Add(new Label() { Text = quoteNumber }, 1, 0);
            tblQuotatiomNo.Controls.Add(new Label() { Text = DateTime.Now.ToString("dd-MMM-yy") }, 1, 1);
        }
        public void SchoolLoad()
        {
            cmd = new SqlCommand("Select SchoolName,SchoolRep,Address from Schools where SchoolId = " + Home.SchoolId, cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            QlbSchoolRep.Text = dt.Rows[0].ItemArray[0].ToString();
            QlbSchoolName.Text = dt.Rows[0].ItemArray[1].ToString();
            QlbSchoolAddress.Text = dt.Rows[0].ItemArray[2].ToString();

            label2.Text = "Quotation for the supply of " + Home.Brand + " School Uniform Shoes for the Academic Year " + DateTime.Now.Year.ToString();

            label4.Text = "As per our discussion, we hereunder submit the quotation for the supply of " + Home.Brand + " School Uniform Shoes for the academic year" + DateTime.Now.Year.ToString();

        }
        public void ProductsLoad()
        {
            List<Quotations> quotationsLst = new List<Quotations>();
            DataTable dtModel = new DataTable();
            if (String.IsNullOrEmpty(Home.Model))
            {
                cmd = new SqlCommand("Select Brand,Model,Color,Size,MRP from Products where Brand = '" + Home.Brand + "'", cn);
                dr = cmd.ExecuteReader();
                dtModel.Load(dr);
            }
            else
            {
                cmd = new SqlCommand("Select Brand,Model,Color,Size,MRP from Products where Brand = '" + Home.Brand + "' and Model = '" + Home.Model + "'", cn);
                dr = cmd.ExecuteReader();
                dtModel.Load(dr);
            }
            foreach (DataRow row in dtModel.Rows)
            {
                Quotations quotation = new Quotations()
                {
                    Brand = row[0].ToString(),
                    Model = row[1].ToString(),
                    Color = row[2].ToString(),
                    Size = row[3].ToString(),
                    MRP = Convert.ToDouble(row[4].ToString()),
                };
                if (Home.Disount > 0)
                    quotation.BasePrice = quotation.MRP - (quotation.MRP * Home.Disount / 100);
                else
                    quotation.BasePrice = quotation.MRP;
                if (quotation.BasePrice < 1000)
                    quotation.GST = (quotation.BasePrice * 12 / 100);
                else
                    quotation.GST = (quotation.BasePrice * 18 / 100);
                quotation.OfferPrice = quotation.BasePrice + quotation.GST;
                quotationsLst.Add(quotation);
            }

            dataGridViewQuotation.DataSource = quotationsLst;
        }
        private void Quotation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
            LoadQuoteNumber();
            SchoolLoad();
            ProductsLoad();
            tableLayoutPanel1.Controls.Add(dataGridViewQuotation,0,0);
            tableLayoutPanel1.SetColumnSpan(dataGridViewQuotation, 2);

            tableLayoutPanel1.RowStyles[0] = (new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.RowStyles[1] = (new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.RowStyles[2] = (new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            //tableLayoutPanel1.RowStyles[3] = (new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));


            //tableLayoutPanel1.RowStyles[0].Height = 100;
            //tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
            sizeDGV(dataGridViewQuotation);
            //tableLayoutPanel1.Controls.Add(new Label() { Text = "We look forward for long-term association with your institution." }, 1, 1);
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //string filename = getFilePath();
            //// If the file path is not empty or null, proceed with saving the PDF file.
            //if (!String.IsNullOrEmpty(filename))
            //{
            //    // Create a new instance of the ChromePdfRenderer class.
            //    var renderer = new ChromePdfRenderer();
            //    // Render the file contents of the text box as a PDF document using the ChromePdfRenderer.
            //    var pdfDocument = renderer.RenderingOptions.CreatePdfFormsFromHtml();
            //    // Save the PDF document to the specified file path using the SaveAs method.
            //    pdfDocument.SaveAs(filename);
            //    // Show a message box to indicate that the PDF file has been saved successfully.
            //    MessageBox.Show("PDF has been saved Successfully!");
            //}
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public string getFilePath()
        {
            // Create a new instance of the SaveFileDialog class.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set the initial directory where the SaveFileDialog will open.
            saveFileDialog1.InitialDirectory = @"D:\";

            // Set the title of the SaveFileDialog.
            saveFileDialog1.Title = "Save the PDF Files";

            // Set the SaveFileDialog to check if the specified path exists.
            saveFileDialog1.CheckPathExists = true;

            // Set the default extension for the file type.
            saveFileDialog1.DefaultExt = ".pdf";

            // Set the filter to display only PDF files or all files.
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            // Set the filter index to display the PDF filter as the default.
            saveFileDialog1.FilterIndex = 2;

            // Set the RestoreDirectory property to true so that the SaveFileDialog
            // restores the current directory before closing.
            saveFileDialog1.RestoreDirectory = true;

            // Show the SaveFileDialog and get the result.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // If the user clicked the OK button in the SaveFileDialog, return the selected file path.
                return saveFileDialog1.FileName;
            }
            // If the user did not click the OK button, return an empty string.
            return "";
        }
        public class FinalQuotation
        {
            public int QuotationId { get; set; }
            public string QuotationNumber { get; set; }
            public string SchoolName { get; set; }
            public string SchoolRep { get; set; }
            public string SchoolAddress { get; set; }
            List<Quotations> QuotationData { get; set; }
            public DateTime QuotationDate { get; set; } = DateTime.UtcNow;

        }
        public class Quotations
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public double MRP { get; set; }
            public double? BasePrice { get; set; }
            public double? GST { get; set; }
            public double? OfferPrice { get; set; }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a bitmap to hold the form's contents
            Bitmap bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));

            // Adjust the scaling to fit the entire form on the printed page
            float scale = Math.Min(e.MarginBounds.Width / (float)this.Width, e.MarginBounds.Height / (float)this.Height);
            e.Graphics.ScaleTransform(scale, scale);

            // Draw the form onto the printed page
            e.Graphics.DrawImage(bm, e.MarginBounds.Location);
        }
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            // a correction I need
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }
    }
}
