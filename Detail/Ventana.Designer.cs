namespace Detail
{
    partial class Ventana
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
            this.AgregarEstBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrupoTextBox = new System.Windows.Forms.TextBox();
            this.ListaGridView1 = new System.Windows.Forms.DataGridView();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EstudiantesComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarEstBoton
            // 
            this.AgregarEstBoton.BackColor = System.Drawing.Color.Pink;
            this.AgregarEstBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarEstBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEstBoton.Location = new System.Drawing.Point(156, 24);
            this.AgregarEstBoton.Name = "AgregarEstBoton";
            this.AgregarEstBoton.Size = new System.Drawing.Size(253, 52);
            this.AgregarEstBoton.TabIndex = 0;
            this.AgregarEstBoton.Text = "Agregar Estudiante";
            this.AgregarEstBoton.UseVisualStyleBackColor = false;
            this.AgregarEstBoton.Click += new System.EventHandler(this.AgregarEstBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo";
            // 
            // GrupoTextBox
            // 
            this.GrupoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoTextBox.Location = new System.Drawing.Point(190, 157);
            this.GrupoTextBox.Name = "GrupoTextBox";
            this.GrupoTextBox.Size = new System.Drawing.Size(307, 26);
            this.GrupoTextBox.TabIndex = 2;
            // 
            // ListaGridView1
            // 
            this.ListaGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ListaGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaGridView1.Location = new System.Drawing.Point(28, 246);
            this.ListaGridView1.Name = "ListaGridView1";
            this.ListaGridView1.Size = new System.Drawing.Size(543, 109);
            this.ListaGridView1.TabIndex = 3;
            this.ListaGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGridView1_CellContentClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(190, 124);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(157, 26);
            this.IdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estudiante ID";
            // 
            // EstudiantesComboBox
            // 
            this.EstudiantesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudiantesComboBox.FormattingEnabled = true;
            this.EstudiantesComboBox.Location = new System.Drawing.Point(190, 195);
            this.EstudiantesComboBox.Name = "EstudiantesComboBox";
            this.EstudiantesComboBox.Size = new System.Drawing.Size(157, 28);
            this.EstudiantesComboBox.TabIndex = 7;
            this.EstudiantesComboBox.SelectedIndexChanged += new System.EventHandler(this.EstudiantesComboBox_SelectedIndexChanged);
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.BackColor = System.Drawing.Color.Pink;
            this.AgregarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBoton.Location = new System.Drawing.Point(358, 195);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(139, 28);
            this.AgregarBoton.TabIndex = 8;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = false;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 408);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.EstudiantesComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.ListaGridView1);
            this.Controls.Add(this.GrupoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarEstBoton);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.Ventana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarEstBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrupoTextBox;
        private System.Windows.Forms.DataGridView ListaGridView1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EstudiantesComboBox;
        private System.Windows.Forms.Button AgregarBoton;
    }
}

