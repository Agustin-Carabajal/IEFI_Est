namespace IEFI_Est
{
    partial class Form4
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
            this.txtExtremoInferiorInterv = new System.Windows.Forms.TextBox();
            this.txtFrecAbsInterv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrecAbsAnteriorInterv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrecAbsPostInterv = new System.Windows.Forms.TextBox();
            this.lblfi = new System.Windows.Forms.Label();
            this.txtAmplitudInterv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSumatoriafi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrecAcumAnterior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModa = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMMRes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medidas de Tendencia Central: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese los datos correspondientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Li = ";
            // 
            // txtExtremoInferiorInterv
            // 
            this.txtExtremoInferiorInterv.Location = new System.Drawing.Point(73, 151);
            this.txtExtremoInferiorInterv.Name = "txtExtremoInferiorInterv";
            this.txtExtremoInferiorInterv.Size = new System.Drawing.Size(44, 20);
            this.txtExtremoInferiorInterv.TabIndex = 3;
            // 
            // txtFrecAbsInterv
            // 
            this.txtFrecAbsInterv.Location = new System.Drawing.Point(186, 151);
            this.txtFrecAbsInterv.Name = "txtFrecAbsInterv";
            this.txtFrecAbsInterv.Size = new System.Drawing.Size(44, 20);
            this.txtFrecAbsInterv.TabIndex = 5;
            this.txtFrecAbsInterv.TextChanged += new System.EventHandler(this.txtFrecAbsInterv_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "fi = ";
            // 
            // txtFrecAbsAnteriorInterv
            // 
            this.txtFrecAbsAnteriorInterv.Location = new System.Drawing.Point(359, 151);
            this.txtFrecAbsAnteriorInterv.Name = "txtFrecAbsAnteriorInterv";
            this.txtFrecAbsAnteriorInterv.Size = new System.Drawing.Size(44, 20);
            this.txtFrecAbsAnteriorInterv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "fi - 1 = ";
            // 
            // txtFrecAbsPostInterv
            // 
            this.txtFrecAbsPostInterv.Location = new System.Drawing.Point(117, 188);
            this.txtFrecAbsPostInterv.Name = "txtFrecAbsPostInterv";
            this.txtFrecAbsPostInterv.Size = new System.Drawing.Size(44, 20);
            this.txtFrecAbsPostInterv.TabIndex = 9;
            // 
            // lblfi
            // 
            this.lblfi.AutoSize = true;
            this.lblfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfi.Location = new System.Drawing.Point(13, 182);
            this.lblfi.Name = "lblfi";
            this.lblfi.Size = new System.Drawing.Size(112, 31);
            this.lblfi.TabIndex = 8;
            this.lblfi.Text = "fi + 1 = ";
            // 
            // txtAmplitudInterv
            // 
            this.txtAmplitudInterv.Location = new System.Drawing.Point(220, 188);
            this.txtAmplitudInterv.Name = "txtAmplitudInterv";
            this.txtAmplitudInterv.Size = new System.Drawing.Size(44, 20);
            this.txtAmplitudInterv.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "ti = ";
            // 
            // txtSumatoriafi
            // 
            this.txtSumatoriafi.Location = new System.Drawing.Point(470, 188);
            this.txtSumatoriafi.Name = "txtSumatoriafi";
            this.txtSumatoriafi.Size = new System.Drawing.Size(44, 20);
            this.txtSumatoriafi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sumatoria fi = ";
            // 
            // txtFrecAcumAnterior
            // 
            this.txtFrecAcumAnterior.Location = new System.Drawing.Point(118, 229);
            this.txtFrecAcumAnterior.Name = "txtFrecAcumAnterior";
            this.txtFrecAcumAnterior.Size = new System.Drawing.Size(39, 20);
            this.txtFrecAcumAnterior.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fi - 1 = ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnModa
            // 
            this.btnModa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModa.Location = new System.Drawing.Point(57, 327);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(101, 51);
            this.btnModa.TabIndex = 16;
            this.btnModa.Text = "Moda";
            this.btnModa.UseVisualStyleBackColor = false;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(167, 327);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(94, 51);
            this.btnMedia.TabIndex = 17;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Resultado = ";
            // 
            // lblMMRes
            // 
            this.lblMMRes.AutoSize = true;
            this.lblMMRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMMRes.Location = new System.Drawing.Point(230, 396);
            this.lblMMRes.Name = "lblMMRes";
            this.lblMMRes.Size = new System.Drawing.Size(55, 31);
            this.lblMMRes.TabIndex = 19;
            this.lblMMRes.Text = "res";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Seleccione lo que desea calcular:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Moda y Media en Datos Agrupados";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMMRes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.txtFrecAcumAnterior);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSumatoriafi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmplitudInterv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFrecAbsPostInterv);
            this.Controls.Add(this.lblfi);
            this.Controls.Add(this.txtFrecAbsAnteriorInterv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFrecAbsInterv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtremoInferiorInterv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtremoInferiorInterv;
        private System.Windows.Forms.TextBox txtFrecAbsInterv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrecAbsAnteriorInterv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrecAbsPostInterv;
        private System.Windows.Forms.Label lblfi;
        private System.Windows.Forms.TextBox txtAmplitudInterv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSumatoriafi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrecAcumAnterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModa;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMMRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}