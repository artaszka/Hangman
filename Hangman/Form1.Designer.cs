namespace Hangman
{
    partial class form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.litera1 = new System.Windows.Forms.Label();
            this.litera2 = new System.Windows.Forms.Label();
            this.litera3 = new System.Windows.Forms.Label();
            this.litera4 = new System.Windows.Forms.Label();
            this.litera5 = new System.Windows.Forms.Label();
            this.litera6 = new System.Windows.Forms.Label();
            this.litera7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLitera = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(482, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // litera1
            // 
            this.litera1.AutoSize = true;
            this.litera1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera1.Location = new System.Drawing.Point(27, 22);
            this.litera1.Name = "litera1";
            this.litera1.Size = new System.Drawing.Size(59, 67);
            this.litera1.TabIndex = 1;
            this.litera1.Text = "_";
            // 
            // litera2
            // 
            this.litera2.AutoSize = true;
            this.litera2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera2.Location = new System.Drawing.Point(92, 22);
            this.litera2.Name = "litera2";
            this.litera2.Size = new System.Drawing.Size(59, 67);
            this.litera2.TabIndex = 2;
            this.litera2.Text = "_";
            // 
            // litera3
            // 
            this.litera3.AutoSize = true;
            this.litera3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera3.Location = new System.Drawing.Point(157, 22);
            this.litera3.Name = "litera3";
            this.litera3.Size = new System.Drawing.Size(59, 67);
            this.litera3.TabIndex = 3;
            this.litera3.Text = "_";
            // 
            // litera4
            // 
            this.litera4.AutoSize = true;
            this.litera4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera4.Location = new System.Drawing.Point(222, 22);
            this.litera4.Name = "litera4";
            this.litera4.Size = new System.Drawing.Size(59, 67);
            this.litera4.TabIndex = 4;
            this.litera4.Text = "_";
            // 
            // litera5
            // 
            this.litera5.AutoSize = true;
            this.litera5.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera5.Location = new System.Drawing.Point(287, 22);
            this.litera5.Name = "litera5";
            this.litera5.Size = new System.Drawing.Size(59, 67);
            this.litera5.TabIndex = 5;
            this.litera5.Text = "_";
            // 
            // litera6
            // 
            this.litera6.AutoSize = true;
            this.litera6.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera6.Location = new System.Drawing.Point(352, 22);
            this.litera6.Name = "litera6";
            this.litera6.Size = new System.Drawing.Size(59, 67);
            this.litera6.TabIndex = 6;
            this.litera6.Text = "_";
            // 
            // litera7
            // 
            this.litera7.AutoSize = true;
            this.litera7.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera7.Location = new System.Drawing.Point(417, 22);
            this.litera7.Name = "litera7";
            this.litera7.Size = new System.Drawing.Size(59, 67);
            this.litera7.TabIndex = 7;
            this.litera7.Text = "_";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(234, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLitera
            // 
            this.tbLitera.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLitera.Location = new System.Drawing.Point(157, 132);
            this.tbLitera.Name = "tbLitera";
            this.tbLitera.Size = new System.Drawing.Size(71, 44);
            this.tbLitera.TabIndex = 9;
            this.tbLitera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 281);
            this.Controls.Add(this.tbLitera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.litera7);
            this.Controls.Add(this.litera6);
            this.Controls.Add(this.litera5);
            this.Controls.Add(this.litera4);
            this.Controls.Add(this.litera3);
            this.Controls.Add(this.litera2);
            this.Controls.Add(this.litera1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label litera1;
        private System.Windows.Forms.Label litera2;
        private System.Windows.Forms.Label litera3;
        private System.Windows.Forms.Label litera4;
        private System.Windows.Forms.Label litera5;
        private System.Windows.Forms.Label litera6;
        private System.Windows.Forms.Label litera7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLitera;
    }
}

