namespace HashText
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenSalt = new System.Windows.Forms.Button();
            this.btnSaltnHash = new System.Windows.Forms.Button();
            this.btnHash512 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(139, 94);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(500, 20);
            this.txtPlain.TabIndex = 0;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(139, 133);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(500, 20);
            this.txtHash.TabIndex = 1;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(275, 226);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(171, 23);
            this.btnHash.TabIndex = 2;
            this.btnHash.Text = "Hash It!";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(139, 172);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(500, 20);
            this.txtSalt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salt";
            // 
            // btnGenSalt
            // 
            this.btnGenSalt.Location = new System.Drawing.Point(139, 226);
            this.btnGenSalt.Name = "btnGenSalt";
            this.btnGenSalt.Size = new System.Drawing.Size(130, 23);
            this.btnGenSalt.TabIndex = 7;
            this.btnGenSalt.Text = "Generate Salt";
            this.btnGenSalt.UseVisualStyleBackColor = true;
            this.btnGenSalt.Click += new System.EventHandler(this.btnGenSalt_Click);
            // 
            // btnSaltnHash
            // 
            this.btnSaltnHash.Location = new System.Drawing.Point(452, 226);
            this.btnSaltnHash.Name = "btnSaltnHash";
            this.btnSaltnHash.Size = new System.Drawing.Size(187, 23);
            this.btnSaltnHash.TabIndex = 8;
            this.btnSaltnHash.Text = "Add some spice and hash it!";
            this.btnSaltnHash.UseVisualStyleBackColor = true;
            this.btnSaltnHash.Click += new System.EventHandler(this.btnSaltnHash_Click);
            // 
            // btnHash512
            // 
            this.btnHash512.Location = new System.Drawing.Point(275, 279);
            this.btnHash512.Name = "btnHash512";
            this.btnHash512.Size = new System.Drawing.Size(171, 23);
            this.btnHash512.TabIndex = 9;
            this.btnHash512.Text = "SHA512 HASH";
            this.btnHash512.UseVisualStyleBackColor = true;
            this.btnHash512.Click += new System.EventHandler(this.btnHash512_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnHash512);
            this.Controls.Add(this.btnSaltnHash);
            this.Controls.Add(this.btnGenSalt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtPlain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenSalt;
        private System.Windows.Forms.Button btnSaltnHash;
        private System.Windows.Forms.Button btnHash512;
    }
}

