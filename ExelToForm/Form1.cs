using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using Exel = Microsoft.Office.Interop.Excel;
namespace ExelToForm
{
    public partial class Form1 : Form
    {
        string path;
        string pdfPath;
        private System.Data.DataTable db;
        public Form1()
        {
            InitializeComponent();
            db = new System.Data.DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Open Exel | *.xlsx";
            if (fl.ShowDialog() != DialogResult.OK)
                return;
            Exel.Application objWorkExel = new Exel.Application();
            Exel.Workbook objWorkBook = objWorkExel.Workbooks.Open(fl.FileName);
            Exel.Worksheet objWowrkSheet = (Exel.Worksheet)objWorkBook.Sheets[1];
            var lastCell = objWowrkSheet.Cells.SpecialCells(Exel.XlCellType.xlCellTypeLastCell);

            int lastColumn = (int)lastCell.Column;
            int lastRow = (int)lastCell.Row;
            
            //MessageBox.Show(string.Format("Collumns {0}, Rows {1}", lastColumn.ToString(), lastRow.ToString()));

            
            for(int i = 0; i < lastColumn; i++)
            {
                db.Columns.Add(objWowrkSheet.Cells[1, i + 1].Text);
            }
            
            for (int j =0; j < lastRow; j++)
            {
                DataRow row = db.NewRow();
                for(int i = 0; i < lastColumn; i++)
                {
                    //list[i,j] = objWowrkSheet.Cells[i+1, j+1].Text;
          
                    row[i] = objWowrkSheet.Cells[j + 2, i + 1].Text;
                   
                }
                db.Rows.Add(row);
            }
            objWorkBook.Close(false, Type.Missing, Type.Missing);
            objWorkExel.Quit();

            dataGridView1.DataSource = db;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            
            if (fl.ShowDialog() != DialogResult.OK)
                return;

            path = fl.FileName;
            print_btn.Visible = true;
            pdf_export.Visible = true;
            
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if(assistant_combo.SelectedItem == null)
            {
                MessageBox.Show("აირჩიეთ თანაშემწე", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Asystant asis = (Asystant)assistant_combo.SelectedItem;
            for (int i = 0; i < db.Rows.Count; i++)
            {
                printIfno.Text = $"იბეჭდება: {db.Rows[i][0]} {db.Rows[i][1]}";
                Document dc = new Document();
                dc.LoadFromFile(path);

                dc.Replace("[name]", db.Rows[i][0].ToString(), false, true);
                dc.Replace("[lastname]", db.Rows[i][1].ToString(), false, true);
                dc.Replace("[number]", db.Rows[i][2].ToString(), false, true);
                dc.Replace("[address]", db.Rows[i][3].ToString(), false, true);
                dc.Replace("[birthday]", db.Rows[i][4].ToString().Replace("/","."), false, true);
                dc.Replace("[mobile]", db.Rows[i][5].ToString() == string.Empty ? "": db.Rows[i][5].ToString().Insert(3,"-").Insert(6,"-").Insert(9,"-"), false, true);
                dc.Replace("[asisName]", asis.Name, false, true);
                dc.Replace("[asisPhone]", asis.Phone, false, true);
                dataGridView1.Rows[i].Selected = true;

                
                PrintDialog dl = new PrintDialog();
                dl.AllowCurrentPage = true;
                dl.AllowSomePages = true;
                dl.UseEXDialog = true;
                dc.PrintDialog = dl;
                dl.Document = dc.PrintDocument;
                dl.Document.Print();
                dc.Close();
                
                
            }
            MessageBox.Show("ოპერაცია დასურლებულია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pdf_export_Click(object sender, EventArgs e)
        {
            Document dc = new Document();
            SaveFileDialog fl = new SaveFileDialog();
            fl.Filter = "Save To PDF | *.pdf";
            fl.DefaultExt = ".pdf";
            if (fl.ShowDialog() != DialogResult.OK)
                return;
            pdfPath = fl.FileName;
            for (int i = 0; i < db.Rows.Count; i++)
            {
                Document temp = new Document();
                temp.LoadFromFile(path);

                temp.Replace("[name]", db.Rows[i][0].ToString(), false, true);
                temp.Replace("[lastname]", db.Rows[i][1].ToString(), false, true);
                temp.Replace("[number]", db.Rows[i][2].ToString(), false, true);
                temp.Replace("[address]", db.Rows[i][3].ToString(), false, true);
                temp.Replace("[birthday]", db.Rows[i][4].ToString(), false, true);
                temp.Replace("[mobile]", db.Rows[i][5].ToString(), false, true);

                Paragraph p = new Paragraph(dc);
                dc.AddSection();
                p.AppendTextFormField(temp.GetText());
                dc.Sections[i].Paragraphs.Insert(0, p);
                temp.Close();
            }
            dc.SaveToFile(pdfPath);
            MessageBox.Show("Moqmedeba shesrulebula");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load("assistants.xml");
                foreach(XElement asis in xdoc.Element("Asistents").Elements("Asistant"))
                {
                    string name = asis.Element("Name").Value;
                    string phone = asis.Element("Phone").Value;
                    assistant_combo.Items.Add(
                        new Asystant() 
                        { Name = name,
                        Phone = phone }
                        ) ;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assistant_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            
        }
    }
}
