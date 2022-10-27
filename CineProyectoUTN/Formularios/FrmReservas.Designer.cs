namespace CineProyectoUTN.Formularios
{
    partial class FrmReservas
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
            this.numCantTicket = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpConfirmacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCantTicket)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // numCantTicket
            // 
            this.numCantTicket.Location = new System.Drawing.Point(715, 312);
            this.numCantTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCantTicket.Name = "numCantTicket";
            this.numCantTicket.Size = new System.Drawing.Size(311, 27);
            this.numCantTicket.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Cantidad de tickets:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(715, 272);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(311, 27);
            this.txtPrecio.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Precio entrada:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(713, 160);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(311, 28);
            this.cboCliente.TabIndex = 71;
            // 
            // cboFuncion
            // 
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(713, 121);
            this.cboFuncion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(311, 28);
            this.cboFuncion.TabIndex = 70;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(934, 384);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 41);
            this.btnBorrar.TabIndex = 69;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(824, 384);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 41);
            this.btnAgregar.TabIndex = 68;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(713, 384);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 41);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(600, 384);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 41);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpReserva
            // 
            this.dtpReserva.Location = new System.Drawing.Point(714, 199);
            this.dtpReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(310, 27);
            this.dtpReserva.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Fecha reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Funcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(653, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "Reserva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Reservas:";
            // 
            // dtpConfirmacion
            // 
            this.dtpConfirmacion.Location = new System.Drawing.Point(714, 237);
            this.dtpConfirmacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpConfirmacion.Name = "dtpConfirmacion";
            this.dtpConfirmacion.Size = new System.Drawing.Size(310, 27);
            this.dtpConfirmacion.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Fecha confirmacion:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1042, 30);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porGeneroToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // porGeneroToolStripMenuItem
            // 
            this.porGeneroToolStripMenuItem.Name = "porGeneroToolStripMenuItem";
            this.porGeneroToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.porGeneroToolStripMenuItem.Text = "Genero de pelicula";
            this.porGeneroToolStripMenuItem.Click += new System.EventHandler(this.porGeneroToolStripMenuItem_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(30, 100);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.Size = new System.Drawing.Size(511, 388);
            this.dgvReservas.TabIndex = 83;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 548);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.dtpConfirmacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCantTicket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantTicket)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown numCantTicket;
        private Label label7;
        private TextBox txtPrecio;
        private Label label6;
        private ComboBox cboCliente;
        private ComboBox cboFuncion;
        private Button btnBorrar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnCancelar;
        private DateTimePicker dtpReserva;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpConfirmacion;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem porGeneroToolStripMenuItem;
        private DataGridView dgvReservas;
    }
}