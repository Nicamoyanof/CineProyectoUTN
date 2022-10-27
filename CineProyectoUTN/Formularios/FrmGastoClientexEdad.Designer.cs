namespace CineProyectoUTN.Formularios
{
    partial class FrmGastoClientexEdad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGastoClientexEdad));
            this.dgvGastoClientexEdad = new System.Windows.Forms.DataGridView();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoClientexEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGastoClientexEdad
            // 
            this.dgvGastoClientexEdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastoClientexEdad.Location = new System.Drawing.Point(25, 135);
            this.dgvGastoClientexEdad.Name = "dgvGastoClientexEdad";
            this.dgvGastoClientexEdad.RowTemplate.Height = 25;
            this.dgvGastoClientexEdad.Size = new System.Drawing.Size(735, 286);
            this.dgvGastoClientexEdad.TabIndex = 0;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsulta.Location = new System.Drawing.Point(185, 9);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(385, 114);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = resources.GetString("lblConsulta.Text");
            this.lblConsulta.Click += new System.EventHandler(this.lblConsulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(668, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmGastoClientexEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.dgvGastoClientexEdad);
            this.Name = "FrmGastoClientexEdad";
            this.Text = "Gasto Cliente por Edad";
            this.Load += new System.EventHandler(this.FrmGastoClientexEdad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoClientexEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvGastoClientexEdad;
        private Label lblConsulta;
        private Button btnSalir;
    }
}