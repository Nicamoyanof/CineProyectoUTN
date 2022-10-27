namespace CineProyectoUTN.Formularios
{
    partial class FrmGastoPromedioxCliente
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
            this.dgvGastoPromedioxCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoPromedioxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGastoPromedioxCliente
            // 
            this.dgvGastoPromedioxCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastoPromedioxCliente.Location = new System.Drawing.Point(50, 78);
            this.dgvGastoPromedioxCliente.Name = "dgvGastoPromedioxCliente";
            this.dgvGastoPromedioxCliente.RowTemplate.Height = 25;
            this.dgvGastoPromedioxCliente.Size = new System.Drawing.Size(680, 330);
            this.dgvGastoPromedioxCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gasto promedio por cliente en el dia 01/10/2022";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(622, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGastoPromedioxCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGastoPromedioxCliente);
            this.Name = "FrmGastoPromedioxCliente";
            this.Text = "Gasto Promedio por Cliente";
            this.Load += new System.EventHandler(this.FrmGastoPromedioxCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoPromedioxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvGastoPromedioxCliente;
        private Label label1;
        private Button btnSalir;
    }
}