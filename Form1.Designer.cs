namespace Sayıları_Yazıya_Çevir
{
    partial class Form1
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
            this.buttonCevir = new System.Windows.Forms.Button();
            this.textBoxSayi = new System.Windows.Forms.TextBox();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCevir
            // 
            this.buttonCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.buttonCevir.Location = new System.Drawing.Point(416, 20);
            this.buttonCevir.Name = "buttonCevir";
            this.buttonCevir.Size = new System.Drawing.Size(83, 34);
            this.buttonCevir.TabIndex = 0;
            this.buttonCevir.Text = "Çevir";
            this.buttonCevir.UseVisualStyleBackColor = true;
            this.buttonCevir.Click += new System.EventHandler(this.buttonCevir_Click);
            // 
            // textBoxSayi
            // 
            this.textBoxSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSayi.Location = new System.Drawing.Point(28, 23);
            this.textBoxSayi.MaxLength = 4;
            this.textBoxSayi.Name = "textBoxSayi";
            this.textBoxSayi.Size = new System.Drawing.Size(370, 31);
            this.textBoxSayi.TabIndex = 1;
            this.textBoxSayi.TextChanged += new System.EventHandler(this.textBoxSayi_TextChanged);
            this.textBoxSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSayi_KeyPress);
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMetin.Location = new System.Drawing.Point(28, 67);
            this.textBoxMetin.Multiline = true;
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(471, 277);
            this.textBoxMetin.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.textBoxSayi);
            this.Controls.Add(this.buttonCevir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCevir;
        private System.Windows.Forms.TextBox textBoxSayi;
        private System.Windows.Forms.TextBox textBoxMetin;
    }
}

