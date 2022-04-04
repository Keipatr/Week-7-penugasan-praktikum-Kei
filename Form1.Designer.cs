namespace Week_7_penugasan_praktikum
{
    partial class formQuizPanda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.textBoxUbah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(165, 34);
            this.textBoxKalimat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(294, 23);
            this.textBoxKalimat.TabIndex = 2;
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Location = new System.Drawing.Point(165, 65);
            this.textBoxHuruf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(110, 23);
            this.textBoxHuruf.TabIndex = 3;
            // 
            // textBoxUbah
            // 
            this.textBoxUbah.Location = new System.Drawing.Point(349, 65);
            this.textBoxUbah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUbah.Name = "textBoxUbah";
            this.textBoxUbah.Size = new System.Drawing.Size(110, 23);
            this.textBoxUbah.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menjadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil :";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(165, 142);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 15);
            this.labelOutput.TabIndex = 7;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(165, 112);
            this.buttonKonversi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(293, 22);
            this.buttonKonversi.TabIndex = 8;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // formQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 185);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUbah);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formQuizPanda";
            this.Text = "QUIZ PANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKalimat;
        private TextBox textBoxHuruf;
        private TextBox textBoxUbah;
        private Label label3;
        private Label label4;
        private Label labelOutput;
        private Button buttonKonversi;
    }
}