namespace DDAvsBresenham
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timedda = new System.Windows.Forms.Label();
            this.timebresenham = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblinitialpoint = new System.Windows.Forms.Label();
            this.lblfinalpoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bresenham";
            // 
            // timedda
            // 
            this.timedda.AutoSize = true;
            this.timedda.Location = new System.Drawing.Point(147, 35);
            this.timedda.Name = "timedda";
            this.timedda.Size = new System.Drawing.Size(22, 13);
            this.timedda.TabIndex = 5;
            this.timedda.Text = "0:0";
            // 
            // timebresenham
            // 
            this.timebresenham.AutoSize = true;
            this.timebresenham.Location = new System.Drawing.Point(232, 35);
            this.timebresenham.Name = "timebresenham";
            this.timebresenham.Size = new System.Drawing.Size(28, 13);
            this.timebresenham.TabIndex = 7;
            this.timebresenham.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiempo";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(420, 229);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(125, 23);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Limpiar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(35, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 350);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Punto Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Punto Final";
            // 
            // lblinitialpoint
            // 
            this.lblinitialpoint.AutoSize = true;
            this.lblinitialpoint.Location = new System.Drawing.Point(449, 108);
            this.lblinitialpoint.Name = "lblinitialpoint";
            this.lblinitialpoint.Size = new System.Drawing.Size(46, 13);
            this.lblinitialpoint.TabIndex = 12;
            this.lblinitialpoint.Text = "(00 , 00)";
            // 
            // lblfinalpoint
            // 
            this.lblfinalpoint.AutoSize = true;
            this.lblfinalpoint.Location = new System.Drawing.Point(452, 191);
            this.lblfinalpoint.Name = "lblfinalpoint";
            this.lblfinalpoint.Size = new System.Drawing.Size(46, 13);
            this.lblfinalpoint.TabIndex = 13;
            this.lblfinalpoint.Text = "(00 , 00)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 430);
            this.Controls.Add(this.lblfinalpoint);
            this.Controls.Add(this.lblinitialpoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.timebresenham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timedda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dubujo de lineas con DDA & Bresenham";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timedda;
        private System.Windows.Forms.Label timebresenham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblinitialpoint;
        private System.Windows.Forms.Label lblfinalpoint;
    }
}

