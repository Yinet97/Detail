namespace Detail.UI.Consultas
{
    partial class Consulta
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultarBoton = new System.Windows.Forms.Button();
            this.ListadoDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(177, 53);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(307, 26);
            this.searchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre o ID";
            // 
            // ConsultarBoton
            // 
            this.ConsultarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBoton.Location = new System.Drawing.Point(531, 45);
            this.ConsultarBoton.Name = "ConsultarBoton";
            this.ConsultarBoton.Size = new System.Drawing.Size(119, 42);
            this.ConsultarBoton.TabIndex = 2;
            this.ConsultarBoton.Text = "Consultar";
            this.ConsultarBoton.UseVisualStyleBackColor = true;
            this.ConsultarBoton.Click += new System.EventHandler(this.ConsultarBoton_Click);
            // 
            // ListadoDataGridView
            // 
            this.ListadoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDataGridView.Location = new System.Drawing.Point(60, 200);
            this.ListadoDataGridView.Name = "ListadoDataGridView";
            this.ListadoDataGridView.Size = new System.Drawing.Size(759, 201);
            this.ListadoDataGridView.TabIndex = 3;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.ListadoDataGridView);
            this.Controls.Add(this.ConsultarBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConsultarBoton;
        private System.Windows.Forms.DataGridView ListadoDataGridView;
    }
}