using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1
{
    public partial class frmMain : Form
    {
        List<string> municipios = new List<string> {"TODOS"};
        DataTable dt = new DataTable();
        public frmMain()
        {
            InitializeComponent();
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Id");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Fecha",typeof(DateTime));
            dt.Columns.Add("Estatus");
        }

        private void reiniciar()
        {
            dt.Clear();
            lbEstadoResultado.Text = string.Empty;
            dgvAfiliados.DataSource = null;
            dgvAfiliados.Rows.Clear();
            tsslAfiliadosSeleccionadosResultado.Text = "NA";
            tsslAfiliadosResultado.Text = "NA";
            cmbbMunicipio.SelectedIndex = -1;
            cmbbMunicipio.DataSource = null;
            municipios = new List<string> { "TODOS" };
            cmbbMunicipio.DataSource = municipios;
        }

        private void cargarTabla()
        {
            for (int row = 0; row <= dt.Rows.Count - 1; row++)
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

        private void cargarExcel()
        {
            reiniciar();
            try
            {
                if (ofdImportarExcel.ShowDialog() == DialogResult.OK)
                {
                    

                    string archivo = ofdImportarExcel.FileName;

                    ExcelPackage.License.SetNonCommercialPersonal("Place holder");

                    using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(archivo)))
                    {
                        if (package.Workbook.Worksheets.Count<=0)
                        {
                            MessageBox.Show("Este archivo no tiene datos", "Incompatible",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }

                        ExcelWorksheet worksheet = package.Workbook.Worksheets.First();

                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        if (colCount < 0 && colCount < 7) 
                        {
                            MessageBox.Show("Este archivo no es compatible con el programa", "Incompatible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        dt.Rows.Clear();

                        lbEstadoResultado.Text = worksheet.Cells[2, 2].Text;
                        tsslAfiliadosResultado.Text =(rowCount-1).ToString();
                        tsslAfiliadosSeleccionadosResultado.Text=(rowCount - 1).ToString();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            dt.Rows.Add(
                                worksheet.Cells[row, 4].Text,
                                worksheet.Cells[row, 1].Text,
                                worksheet.Cells[row, 3].Text,
                                DateTime.ParseExact(worksheet.Cells[row, 5].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                                ,
                                worksheet.Cells[row, 6].Text
                                );
                            if(!municipios.Contains(worksheet.Cells[row, 3].Text))
                            {
                                municipios.Add(worksheet.Cells[row, 3].Text);
                            }
                        }

                        cmbbMunicipio.DataSource = null;
                        cmbbMunicipio.DataSource = municipios;

                        cargarTabla();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Algo terrible ha sucedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            reiniciar();
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

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarMunicipio_Click(object sender, EventArgs e)
        {
            dgvAfiliados.DataSource = null;
            dgvAfiliados.Rows.Clear();

            if (cmbbMunicipio.SelectedIndex == 0)
            {
                if (chkbFechaBuscar.Checked)
                {
                    for (int row = 0; row <= dt.Rows.Count - 1; row++)
                    {
                        if (dtpFecha1.Value.Date < (DateTime)dt.Rows[row][3] && (DateTime)dt.Rows[row][3] < dtpFecha2.Value.Date)
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
                else
                {
                    cargarTabla();
                }
                
            }
            else
            {
                for (int row = 0; row <= dt.Rows.Count - 1; row++)
                {
                    if (cmbbMunicipio.SelectedItem.ToString() == dt.Rows[row][2].ToString())
                    {
                        if (chkbFechaBuscar.Checked)
                        {
                            if (dtpFecha1.Value.Date < (DateTime)dt.Rows[row][3] && (DateTime)dt.Rows[row][3] < dtpFecha2.Value.Date)
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
                        else
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
            tsslAfiliadosSeleccionadosResultado.Text = (dgvAfiliados.Rows.Count-1).ToString();
        }

        private void chkbFechaBuscar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha1_ValueChanged(object sender, EventArgs e)
        {

        }
    }    
}
