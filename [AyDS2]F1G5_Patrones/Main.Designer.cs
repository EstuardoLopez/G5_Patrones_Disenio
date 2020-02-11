namespace _AyDS2_F1G5_Patrones
{
    partial class Main
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDorsal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPosicion = new System.Windows.Forms.ComboBox();
            this.cbxEquipo = new System.Windows.Forms.ComboBox();
            this.Equipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDorsal
            // 
            this.txtDorsal.Location = new System.Drawing.Point(98, 38);
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(249, 20);
            this.txtDorsal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dorsal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Posicion";
            // 
            // cbxPosicion
            // 
            this.cbxPosicion.FormattingEnabled = true;
            this.cbxPosicion.Items.AddRange(new object[] {
            "Portero",
            "Defensa",
            "MedioCampista",
            "Delantero"});
            this.cbxPosicion.Location = new System.Drawing.Point(98, 75);
            this.cbxPosicion.Name = "cbxPosicion";
            this.cbxPosicion.Size = new System.Drawing.Size(249, 21);
            this.cbxPosicion.TabIndex = 8;
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.Items.AddRange(new object[] {
            "Barcelona",
            "Real Madrid"});
            this.cbxEquipo.Location = new System.Drawing.Point(98, 102);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(249, 21);
            this.cbxEquipo.TabIndex = 10;
            this.cbxEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxEquipo_SelectedIndexChanged);
            // 
            // Equipo
            // 
            this.Equipo.AutoSize = true;
            this.Equipo.Location = new System.Drawing.Point(8, 105);
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(40, 13);
            this.Equipo.TabIndex = 9;
            this.Equipo.Text = "Equipo";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 149);
            this.Controls.Add(this.cbxEquipo);
            this.Controls.Add(this.Equipo);
            this.Controls.Add(this.cbxPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDorsal);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPosicion;
        private System.Windows.Forms.ComboBox cbxEquipo;
        private System.Windows.Forms.Label Equipo;
    }
}

