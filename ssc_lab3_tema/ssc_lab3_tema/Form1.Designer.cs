namespace ssc_lab3_tema
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelKeyASCII = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.labelPlainTextASCII = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxMAC = new System.Windows.Forms.TextBox();
            this.textBoxMACHEX = new System.Windows.Forms.TextBox();
            this.labelMAC = new System.Windows.Forms.Label();
            this.labelMACASCII = new System.Windows.Forms.Label();
            this.labelMACHEX = new System.Windows.Forms.Label();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "RIPEMD",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBox.Location = new System.Drawing.Point(47, 38);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(144, 24);
            this.comboBox.TabIndex = 0;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(426, 40);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(224, 22);
            this.textBoxKey.TabIndex = 1;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(423, 20);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(32, 17);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key";
            // 
            // labelKeyASCII
            // 
            this.labelKeyASCII.AutoSize = true;
            this.labelKeyASCII.Location = new System.Drawing.Point(374, 43);
            this.labelKeyASCII.Name = "labelKeyASCII";
            this.labelKeyASCII.Size = new System.Drawing.Size(41, 17);
            this.labelKeyASCII.TabIndex = 3;
            this.labelKeyASCII.Text = "ASCII";
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(47, 123);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(144, 47);
            this.buttonCompute.TabIndex = 4;
            this.buttonCompute.Text = "Compute MAC";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(426, 123);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(224, 22);
            this.textBoxPlain.TabIndex = 5;
            // 
            // labelPlainText
            // 
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Location = new System.Drawing.Point(423, 98);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(70, 17);
            this.labelPlainText.TabIndex = 6;
            this.labelPlainText.Text = "Plain Text";
            // 
            // labelPlainTextASCII
            // 
            this.labelPlainTextASCII.AutoSize = true;
            this.labelPlainTextASCII.Location = new System.Drawing.Point(379, 123);
            this.labelPlainTextASCII.Name = "labelPlainTextASCII";
            this.labelPlainTextASCII.Size = new System.Drawing.Size(41, 17);
            this.labelPlainTextASCII.TabIndex = 7;
            this.labelPlainTextASCII.Text = "ASCII";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(47, 235);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(144, 46);
            this.buttonVerify.TabIndex = 8;
            this.buttonVerify.Text = "Verify MAC";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(426, 235);
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(224, 22);
            this.textBoxMAC.TabIndex = 9;
            // 
            // textBoxMACHEX
            // 
            this.textBoxMACHEX.Location = new System.Drawing.Point(426, 263);
            this.textBoxMACHEX.Name = "textBoxMACHEX";
            this.textBoxMACHEX.Size = new System.Drawing.Size(224, 22);
            this.textBoxMACHEX.TabIndex = 10;
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.Location = new System.Drawing.Point(423, 215);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(37, 17);
            this.labelMAC.TabIndex = 11;
            this.labelMAC.Text = "MAC";
            // 
            // labelMACASCII
            // 
            this.labelMACASCII.AutoSize = true;
            this.labelMACASCII.Location = new System.Drawing.Point(374, 238);
            this.labelMACASCII.Name = "labelMACASCII";
            this.labelMACASCII.Size = new System.Drawing.Size(41, 17);
            this.labelMACASCII.TabIndex = 12;
            this.labelMACASCII.Text = "ASCII";
            // 
            // labelMACHEX
            // 
            this.labelMACHEX.AutoSize = true;
            this.labelMACHEX.Location = new System.Drawing.Point(374, 268);
            this.labelMACHEX.Name = "labelMACHEX";
            this.labelMACHEX.Size = new System.Drawing.Size(36, 17);
            this.labelMACHEX.TabIndex = 13;
            this.labelMACHEX.Text = "HEX";
            // 
            // textBoxHash
            // 
            this.textBoxHash.Location = new System.Drawing.Point(426, 148);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(224, 22);
            this.textBoxHash.TabIndex = 14;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(374, 151);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(46, 17);
            this.labelHash.TabIndex = 15;
            this.labelHash.Text = "HASH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 344);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.labelMACHEX);
            this.Controls.Add(this.labelMACASCII);
            this.Controls.Add(this.labelMAC);
            this.Controls.Add(this.textBoxMACHEX);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.labelPlainTextASCII);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.labelKeyASCII);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelKeyASCII;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Label labelPlainTextASCII;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textBoxMAC;
        private System.Windows.Forms.TextBox textBoxMACHEX;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.Label labelMACASCII;
        private System.Windows.Forms.Label labelMACHEX;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Label labelHash;
    }
}

