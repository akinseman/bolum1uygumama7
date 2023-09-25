namespace bölüm1uygulam7
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
            this.btnSepete_ekle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtmeyve = new System.Windows.Forms.TextBox();
            this.lboxMeyveller = new System.Windows.Forms.ListBox();
            this.btensil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSepete_ekle
            // 
            this.btnSepete_ekle.Location = new System.Drawing.Point(12, 110);
            this.btnSepete_ekle.Name = "btnSepete_ekle";
            this.btnSepete_ekle.Size = new System.Drawing.Size(98, 23);
            this.btnSepete_ekle.TabIndex = 0;
            this.btnSepete_ekle.Text = "sepete ekle";
            this.btnSepete_ekle.UseVisualStyleBackColor = true;
            this.btnSepete_ekle.Click += new System.EventHandler(this.btnSepete_ekle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtmeyve
            // 
            this.txtmeyve.Location = new System.Drawing.Point(12, 74);
            this.txtmeyve.Name = "txtmeyve";
            this.txtmeyve.Size = new System.Drawing.Size(100, 20);
            this.txtmeyve.TabIndex = 2;
            // 
            // lboxMeyveller
            // 
            this.lboxMeyveller.FormattingEnabled = true;
            this.lboxMeyveller.Location = new System.Drawing.Point(150, 74);
            this.lboxMeyveller.Name = "lboxMeyveller";
            this.lboxMeyveller.Size = new System.Drawing.Size(120, 121);
            this.lboxMeyveller.TabIndex = 3;
            // 
            // btensil
            // 
            this.btensil.Location = new System.Drawing.Point(21, 168);
            this.btensil.Name = "btensil";
            this.btensil.Size = new System.Drawing.Size(78, 23);
            this.btensil.TabIndex = 4;
            this.btensil.Text = "Seçili öğyi sil";
            this.btensil.UseVisualStyleBackColor = true;
            this.btensil.Click += new System.EventHandler(this.btensil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btensil);
            this.Controls.Add(this.lboxMeyveller);
            this.Controls.Add(this.txtmeyve);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSepete_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSepete_ekle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtmeyve;
        private System.Windows.Forms.ListBox lboxMeyveller;
        private System.Windows.Forms.Button btensil;
    }
}

