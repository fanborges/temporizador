namespace Reloj
{
    partial class CadenaUnicode
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
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.btn_to_string = new System.Windows.Forms.Button();
            this.btn_unicode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(40, 3);
            this.txt_entrada.Multiline = true;
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(386, 347);
            this.txt_entrada.TabIndex = 1;
            // 
            // btn_to_string
            // 
            this.btn_to_string.Location = new System.Drawing.Point(57, 366);
            this.btn_to_string.Name = "btn_to_string";
            this.btn_to_string.Size = new System.Drawing.Size(75, 23);
            this.btn_to_string.TabIndex = 2;
            this.btn_to_string.Text = "Texto";
            this.btn_to_string.UseVisualStyleBackColor = true;
            // 
            // btn_unicode
            // 
            this.btn_unicode.Location = new System.Drawing.Point(241, 366);
            this.btn_unicode.Name = "btn_unicode";
            this.btn_unicode.Size = new System.Drawing.Size(75, 23);
            this.btn_unicode.TabIndex = 3;
            this.btn_unicode.Text = "Unicode";
            this.btn_unicode.UseVisualStyleBackColor = true;
            this.btn_unicode.Click += new System.EventHandler(this.btn_unicode_Click);
            // 
            // CadenaUnicode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 401);
            this.Controls.Add(this.btn_unicode);
            this.Controls.Add(this.btn_to_string);
            this.Controls.Add(this.txt_entrada);
            this.Name = "CadenaUnicode";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Button btn_to_string;
        private System.Windows.Forms.Button btn_unicode;
    }
}