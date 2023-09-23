using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestInterop_paolaCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnGuardarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            String dato = TextBox1.Text;

            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnGuardarExcel_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog dialogo = new SaveFileDialog();
                if (dialogo.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string dato = TextBox1.Text;
                string ruta = dialogo.FileName;
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                excelApp.Workbooks.Add();
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                workSheet.Cells[1, "A"] = dato;
                workSheet.Columns[1].AutoFit();

                workSheet.SaveAs(ruta);

            
             }
        }
    }
}




