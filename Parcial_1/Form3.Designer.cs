namespace IEFI_Est
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPermutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPermutacion = new System.Windows.Forms.Label();
            this.txtSeleccN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelecK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImporta = new System.Windows.Forms.Button();
            this.btnNoImporta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelecResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPermutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Permutar n elementos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccionar k elementos de un conjunto n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "n = ";
            // 
            // txtPermutar
            // 
            this.txtPermutar.Location = new System.Drawing.Point(89, 74);
            this.txtPermutar.Name = "txtPermutar";
            this.txtPermutar.Size = new System.Drawing.Size(57, 20);
            this.txtPermutar.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Resultado = ";
            // 
            // lblPermutacion
            // 
            this.lblPermutacion.AutoSize = true;
            this.lblPermutacion.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermutacion.Location = new System.Drawing.Point(348, 67);
            this.lblPermutacion.Name = "lblPermutacion";
            this.lblPermutacion.Size = new System.Drawing.Size(149, 32);
            this.lblPermutacion.TabIndex = 28;
            this.lblPermutacion.Text = "Resultado";
            // 
            // txtSeleccN
            // 
            this.txtSeleccN.Location = new System.Drawing.Point(69, 276);
            this.txtSeleccN.Name = "txtSeleccN";
            this.txtSeleccN.Size = new System.Drawing.Size(57, 20);
            this.txtSeleccN.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "n = ";
            // 
            // txtSelecK
            // 
            this.txtSelecK.Location = new System.Drawing.Point(190, 274);
            this.txtSelecK.Name = "txtSelecK";
            this.txtSelecK.Size = new System.Drawing.Size(57, 20);
            this.txtSelecK.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "k = ";
            // 
            // btnImporta
            // 
            this.btnImporta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImporta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImporta.Location = new System.Drawing.Point(67, 335);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(118, 67);
            this.btnImporta.TabIndex = 33;
            this.btnImporta.Text = "Importa el orden";
            this.btnImporta.UseVisualStyleBackColor = false;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // btnNoImporta
            // 
            this.btnNoImporta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNoImporta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoImporta.Location = new System.Drawing.Point(220, 335);
            this.btnNoImporta.Name = "btnNoImporta";
            this.btnNoImporta.Size = new System.Drawing.Size(122, 67);
            this.btnNoImporta.TabIndex = 34;
            this.btnNoImporta.Text = "No importa el orden";
            this.btnNoImporta.UseVisualStyleBackColor = false;
            this.btnNoImporta.Click += new System.EventHandler(this.btnNoImporta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "Resultado = ";
            // 
            // lblSelecResult
            // 
            this.lblSelecResult.AutoSize = true;
            this.lblSelecResult.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecResult.Location = new System.Drawing.Point(434, 268);
            this.lblSelecResult.Name = "lblSelecResult";
            this.lblSelecResult.Size = new System.Drawing.Size(104, 32);
            this.lblSelecResult.TabIndex = 36;
            this.lblSelecResult.Text = "result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 39);
            this.label8.TabIndex = 37;
            this.label8.Text = "(";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "k";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(69, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 39);
            this.label11.TabIndex = 40;
            this.label11.Text = ")";
            // 
            // btnPermutar
            // 
            this.btnPermutar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPermutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermutar.Location = new System.Drawing.Point(67, 114);
            this.btnPermutar.Name = "btnPermutar";
            this.btnPermutar.Size = new System.Drawing.Size(106, 30);
            this.btnPermutar.TabIndex = 41;
            this.btnPermutar.Text = "Permutar";
            this.btnPermutar.UseVisualStyleBackColor = false;
            this.btnPermutar.Click += new System.EventHandler(this.btnPermutar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btnPermutar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSelecResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNoImporta);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.txtSelecK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSeleccN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPermutacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPermutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPermutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPermutacion;
        private System.Windows.Forms.TextBox txtSeleccN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelecK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.Button btnNoImporta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSelecResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPermutar;
    }
}