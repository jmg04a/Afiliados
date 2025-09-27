using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace Proyecto1
{
    public partial class frmMain : Form
    {
        //List<string> columnas;
        public frmMain()
        {
            InitializeComponent();
            /*columnas = new List<string>
            {
                "Nombre",
                "Id",
                "Municipio",
                "Fecha",
                "Estatus",
            };*/
        }

        //Funcion para establecer los objetos de la interfaz en sus valores por defecto
        private void limpiar()
        {
            tbEstado.Text = string.Empty;
            tsslNumeroAfilados.Text = "NA";
            cmbbMunicipio.SelectedIndex = 0;
            dgvAfiliados.DataSource = null;
            dgvAfiliados.Rows.Clear(); 
        }

        private void cargarExcel()
        {
            try
            {
                if (ofdImportarExcel.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();

                    string archivo = ofdImportarExcel.FileName;

                    ExcelPackage.License.SetNonCommercialPersonal("Place holder");

                    using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(archivo)))
                    {

                        ExcelWorksheet worksheet = package.Workbook.Worksheets.First();

                        // Leer el número de filas y columnas con datos
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        /*foreach (var col in columnas)
                        {
                            dt.Columns.Add(col);
                        }*/

                        for (int i = 1; i <= 5; i++) 
                        {
                            dt.Columns.Add();
                        }

                        tbEstado.Text = worksheet.Cells[2, 2].Text;
                        tsslNumeroAfilados.Text = (rowCount-1).ToString();

                        for (int row = 1; row <= rowCount; row++)
                        {
                            dt.Rows.Add(
                                worksheet.Cells[row, 4].Text,
                                worksheet.Cells[row, 1].Text,
                                worksheet.Cells[row, 3].Text,
                                worksheet.Cells[row, 5].Text,
                                worksheet.Cells[row, 6].Text
                                );
                        }

                        for (int row = 0; row <= dt.Rows.Count-1; row++)
                        {
                            dgvAfiliados.Rows.Add(
                                dt.Rows[row][0].ToString(),
                                dt.Rows[row][1].ToString(),
                                dt.Rows[row][2].ToString(),
                                dt.Rows[row][3].ToString(),
                                dt.Rows[row][4].ToString()
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex, "Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmImportar_Click(object sender, EventArgs e)
        {
            cargarExcel();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ofdImportarBaseDatos_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
