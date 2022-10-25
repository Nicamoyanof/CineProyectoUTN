namespace CineProyectoUTN.Formularios
{
    partial class FrmClienteFuncion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de clientes que mas entradas compraron por funcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.pelicula,
            this.cant_entradas,
            this.funcion});
            this.dataGridView1.Location = new System.Drawing.Point(111, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(554, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Cliente";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // pelicula
            // 
            this.pelicula.HeaderText = "Pelicula";
            this.pelicula.Name = "pelicula";
            this.pelicula.ReadOnly = true;
            this.pelicula.Width = 150;
            // 
            // cant_entradas
            // 
            this.cant_entradas.HeaderText = "Cantidad de entradas";
            this.cant_entradas.Name = "cant_entradas";
            this.cant_entradas.ReadOnly = true;
            // 
            // funcion
            // 
            this.funcion.HeaderText = "Horario funcion";
            this.funcion.Name = "funcion";
            this.funcion.ReadOnly = true;
            this.funcion.Width = 150;
            // 
            // FrmClienteFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmClienteFuncion";
            this.Text = "FrmClienteFuncion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn cant_entradas;
        private DataGridViewTextBoxColumn funcion;
    }
}