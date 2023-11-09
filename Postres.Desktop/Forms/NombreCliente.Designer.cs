namespace Postres.Desktop.Forms 
{
    partial class NombreCliente
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
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Cliente";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(88, 70);
            this.Nombretxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(161, 20);
            this.Nombretxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // CrearBtn
            // 
            this.CrearBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.CrearBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CrearBtn.Location = new System.Drawing.Point(179, 98);
            this.CrearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(69, 29);
            this.CrearBtn.TabIndex = 3;
            this.CrearBtn.Text = "Crear";
            this.CrearBtn.UseVisualStyleBackColor = false;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click);
            // 
            // CrearPostre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 292);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearPostre";
            this.Text = "CrearPostre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CrearBtn;
    }
}