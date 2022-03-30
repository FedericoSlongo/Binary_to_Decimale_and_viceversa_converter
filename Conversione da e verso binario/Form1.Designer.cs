
namespace Conversione_da_e_verso_binario
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.converti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_binario = new System.Windows.Forms.TextBox();
            this.txb_decimale = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // converti
            // 
            this.converti.Location = new System.Drawing.Point(209, 81);
            this.converti.Name = "converti";
            this.converti.Size = new System.Drawing.Size(75, 23);
            this.converti.TabIndex = 0;
            this.converti.Text = "Converti";
            this.converti.UseVisualStyleBackColor = true;
            this.converti.Click += new System.EventHandler(this.converti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversione da binario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversione da decimale";
            // 
            // txb_binario
            // 
            this.txb_binario.Location = new System.Drawing.Point(16, 34);
            this.txb_binario.Name = "txb_binario";
            this.txb_binario.Size = new System.Drawing.Size(151, 22);
            this.txb_binario.TabIndex = 3;
            // 
            // txb_decimale
            // 
            this.txb_decimale.Location = new System.Drawing.Point(16, 152);
            this.txb_decimale.Name = "txb_decimale";
            this.txb_decimale.Size = new System.Drawing.Size(151, 22);
            this.txb_decimale.TabIndex = 4;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(396, 10);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(63, 23);
            this.del.TabIndex = 5;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(396, 40);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(63, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(396, 125);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(28, 23);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(396, 153);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(28, 23);
            this.zero.TabIndex = 8;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-659, -374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1774, 876);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 195);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.del);
            this.Controls.Add(this.txb_decimale);
            this.Controls.Add(this.txb_binario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converti);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Conversione da e verso binario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button converti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_binario;
        private System.Windows.Forms.TextBox txb_decimale;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

