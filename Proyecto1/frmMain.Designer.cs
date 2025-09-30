namespace Proyecto1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.cmbbMunicipio = new System.Windows.Forms.ComboBox();
            this.dgvAfiliados = new System.Windows.Forms.DataGridView();
            this.afiliadoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliadosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliadosMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliadosFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliadosEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.tsmImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImportarExcel = new System.Windows.Forms.OpenFileDialog();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lbFecha2 = new System.Windows.Forms.Label();
            this.lbFecha1 = new System.Windows.Forms.Label();
            this.chkbFechaBuscar = new System.Windows.Forms.CheckBox();
            this.tsslAfiliadosResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssInformacion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAfiliadosSeleccionadosResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBuscarMunicipio = new System.Windows.Forms.Button();
            this.lbEstadoResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).BeginInit();
            this.msOpciones.SuspendLayout();
            this.ssInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(129, 82);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(84, 25);
            this.lbEstado.TabIndex = 2;
            this.lbEstado.Text = "Estado: ";
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.AutoSize = true;
            this.lbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMunicipio.Location = new System.Drawing.Point(112, 135);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(101, 25);
            this.lbMunicipio.TabIndex = 4;
            this.lbMunicipio.Text = "Municipio:";
            // 
            // cmbbMunicipio
            // 
            this.cmbbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbMunicipio.FormattingEnabled = true;
            this.cmbbMunicipio.Location = new System.Drawing.Point(219, 132);
            this.cmbbMunicipio.Name = "cmbbMunicipio";
            this.cmbbMunicipio.Size = new System.Drawing.Size(366, 33);
            this.cmbbMunicipio.TabIndex = 5;
            this.cmbbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbbMunicipio_SelectedIndexChanged);
            // 
            // dgvAfiliados
            // 
            this.dgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.afiliadoNombre,
            this.afiliadosId,
            this.afiliadosMunicipio,
            this.afiliadosFecha,
            this.afiliadosEstatus});
            this.dgvAfiliados.Location = new System.Drawing.Point(12, 264);
            this.dgvAfiliados.Name = "dgvAfiliados";
            this.dgvAfiliados.RowHeadersWidth = 62;
            this.dgvAfiliados.RowTemplate.Height = 28;
            this.dgvAfiliados.Size = new System.Drawing.Size(1218, 484);
            this.dgvAfiliados.TabIndex = 6;
            this.dgvAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // afiliadoNombre
            // 
            this.afiliadoNombre.HeaderText = "Nombre";
            this.afiliadoNombre.MinimumWidth = 8;
            this.afiliadoNombre.Name = "afiliadoNombre";
            this.afiliadoNombre.ReadOnly = true;
            this.afiliadoNombre.Width = 180;
            // 
            // afiliadosId
            // 
            this.afiliadosId.HeaderText = "Id";
            this.afiliadosId.MinimumWidth = 8;
            this.afiliadosId.Name = "afiliadosId";
            this.afiliadosId.ReadOnly = true;
            this.afiliadosId.Width = 50;
            // 
            // afiliadosMunicipio
            // 
            this.afiliadosMunicipio.HeaderText = "Municipio";
            this.afiliadosMunicipio.MinimumWidth = 8;
            this.afiliadosMunicipio.Name = "afiliadosMunicipio";
            this.afiliadosMunicipio.ReadOnly = true;
            this.afiliadosMunicipio.Width = 180;
            // 
            // afiliadosFecha
            // 
            this.afiliadosFecha.HeaderText = "Fecha";
            this.afiliadosFecha.MinimumWidth = 8;
            this.afiliadosFecha.Name = "afiliadosFecha";
            this.afiliadosFecha.ReadOnly = true;
            this.afiliadosFecha.Width = 150;
            // 
            // afiliadosEstatus
            // 
            this.afiliadosEstatus.HeaderText = "Estatus";
            this.afiliadosEstatus.MinimumWidth = 8;
            this.afiliadosEstatus.Name = "afiliadosEstatus";
            this.afiliadosEstatus.ReadOnly = true;
            this.afiliadosEstatus.Width = 150;
            // 
            // msOpciones
            // 
            this.msOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOpciones.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImportar,
            this.tsmReiniciar});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(1370, 33);
            this.msOpciones.TabIndex = 13;
            this.msOpciones.Text = "menuStrip1";
            // 
            // tsmImportar
            // 
            this.tsmImportar.Name = "tsmImportar";
            this.tsmImportar.Size = new System.Drawing.Size(99, 29);
            this.tsmImportar.Text = "Importar";
            this.tsmImportar.Click += new System.EventHandler(this.tsmImportar_Click);
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(102, 29);
            this.tsmReiniciar.Text = "Reiniciar";
            this.tsmReiniciar.Click += new System.EventHandler(this.tsmReiniciar_Click);
            // 
            // ofdImportarExcel
            // 
            this.ofdImportarExcel.FileName = "openFileDialog1";
            this.ofdImportarExcel.Filter = "Archivo de Excel|*.xlsx";
            this.ofdImportarExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImportarBaseDatos_FileOk);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Location = new System.Drawing.Point(781, 162);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(348, 30);
            this.dtpFecha2.TabIndex = 21;
            this.dtpFecha2.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Location = new System.Drawing.Point(781, 125);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(348, 30);
            this.dtpFecha1.TabIndex = 20;
            this.dtpFecha1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.ValueChanged += new System.EventHandler(this.dtpFecha1_ValueChanged);
            // 
            // lbFecha2
            // 
            this.lbFecha2.AutoSize = true;
            this.lbFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha2.Location = new System.Drawing.Point(657, 167);
            this.lbFecha2.Name = "lbFecha2";
            this.lbFecha2.Size = new System.Drawing.Size(90, 25);
            this.lbFecha2.TabIndex = 19;
            this.lbFecha2.Text = "Antes de";
            // 
            // lbFecha1
            // 
            this.lbFecha1.AutoSize = true;
            this.lbFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha1.Location = new System.Drawing.Point(656, 130);
            this.lbFecha1.Name = "lbFecha1";
            this.lbFecha1.Size = new System.Drawing.Size(117, 25);
            this.lbFecha1.TabIndex = 18;
            this.lbFecha1.Text = "Despues de";
            // 
            // chkbFechaBuscar
            // 
            this.chkbFechaBuscar.AutoSize = true;
            this.chkbFechaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFechaBuscar.Location = new System.Drawing.Point(656, 74);
            this.chkbFechaBuscar.Name = "chkbFechaBuscar";
            this.chkbFechaBuscar.Size = new System.Drawing.Size(185, 29);
            this.chkbFechaBuscar.TabIndex = 17;
            this.chkbFechaBuscar.Text = "Buscar por fecha";
            this.chkbFechaBuscar.UseVisualStyleBackColor = true;
            this.chkbFechaBuscar.CheckedChanged += new System.EventHandler(this.chkbFechaBuscar_CheckedChanged);
            // 
            // tsslAfiliadosResultado
            // 
            this.tsslAfiliadosResultado.Name = "tsslAfiliadosResultado";
            this.tsslAfiliadosResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslAfiliadosResultado.Size = new System.Drawing.Size(0, 25);
            this.tsslAfiliadosResultado.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ssInformacion
            // 
            this.ssInformacion.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tsslAfiliadosResultado,
            this.toolStripStatusLabel1,
            this.tsslAfiliadosSeleccionadosResultado,
            this.toolStripStatusLabel2});
            this.ssInformacion.Location = new System.Drawing.Point(0, 817);
            this.ssInformacion.Name = "ssInformacion";
            this.ssInformacion.Size = new System.Drawing.Size(1370, 32);
            this.ssInformacion.TabIndex = 16;
            this.ssInformacion.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(235, 25);
            this.toolStripStatusLabel3.Text = "Numero de afiliados totales:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(292, 25);
            this.toolStripStatusLabel1.Text = "Numero de afiliados seleccionados:";
            // 
            // tsslAfiliadosSeleccionadosResultado
            // 
            this.tsslAfiliadosSeleccionadosResultado.Name = "tsslAfiliadosSeleccionadosResultado";
            this.tsslAfiliadosSeleccionadosResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslAfiliadosSeleccionadosResultado.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 25);
            // 
            // btnBuscarMunicipio
            // 
            this.btnBuscarMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarMunicipio.Location = new System.Drawing.Point(218, 171);
            this.btnBuscarMunicipio.Name = "btnBuscarMunicipio";
            this.btnBuscarMunicipio.Size = new System.Drawing.Size(366, 48);
            this.btnBuscarMunicipio.TabIndex = 22;
            this.btnBuscarMunicipio.Text = "Buscar";
            this.btnBuscarMunicipio.UseVisualStyleBackColor = true;
            this.btnBuscarMunicipio.Click += new System.EventHandler(this.btnBuscarMunicipio_Click);
            // 
            // lbEstadoResultado
            // 
            this.lbEstadoResultado.AutoSize = true;
            this.lbEstadoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEstadoResultado.Location = new System.Drawing.Point(213, 78);
            this.lbEstadoResultado.Name = "lbEstadoResultado";
            this.lbEstadoResultado.Size = new System.Drawing.Size(0, 25);
            this.lbEstadoResultado.TabIndex = 23;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 849);
            this.Controls.Add(this.lbEstadoResultado);
            this.Controls.Add(this.btnBuscarMunicipio);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.lbFecha2);
            this.Controls.Add(this.lbFecha1);
            this.Controls.Add(this.chkbFechaBuscar);
            this.Controls.Add(this.ssInformacion);
            this.Controls.Add(this.dgvAfiliados);
            this.Controls.Add(this.cmbbMunicipio);
            this.Controls.Add(this.lbMunicipio);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.msOpciones);
            this.MainMenuStrip = this.msOpciones;
            this.Name = "frmMain";
            this.Text = "                                                                                 " +
    "                   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).EndInit();
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.ssInformacion.ResumeLayout(false);
            this.ssInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.ComboBox cmbbMunicipio;
        private System.Windows.Forms.DataGridView dgvAfiliados;
        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmImportar;
        private System.Windows.Forms.OpenFileDialog ofdImportarExcel;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label lbFecha2;
        private System.Windows.Forms.Label lbFecha1;
        private System.Windows.Forms.CheckBox chkbFechaBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliadoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliadosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliadosMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliadosFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliadosEstatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslAfiliadosResultado;
        private System.Windows.Forms.StatusStrip ssInformacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslAfiliadosSeleccionadosResultado;
        private System.Windows.Forms.Button btnBuscarMunicipio;
        private System.Windows.Forms.Label lbEstadoResultado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

