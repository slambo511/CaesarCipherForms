
namespace CaesarCipherForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnEncipher = new System.Windows.Forms.Button();
            this.BtnDecipher = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.NupCodeValue = new System.Windows.Forms.NumericUpDown();
            this.BtnTryAll = new System.Windows.Forms.Button();
            this.LblCipherNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NupCodeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(23, 22);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(832, 123);
            this.TxtInput.TabIndex = 0;
            // 
            // BtnEncipher
            // 
            this.BtnEncipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEncipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncipher.Location = new System.Drawing.Point(23, 151);
            this.BtnEncipher.Name = "BtnEncipher";
            this.BtnEncipher.Size = new System.Drawing.Size(191, 55);
            this.BtnEncipher.TabIndex = 1;
            this.BtnEncipher.Text = "&Encipher";
            this.BtnEncipher.UseVisualStyleBackColor = true;
            this.BtnEncipher.Click += new System.EventHandler(this.BtnEncipher_Click);
            // 
            // BtnDecipher
            // 
            this.BtnDecipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDecipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecipher.Location = new System.Drawing.Point(23, 273);
            this.BtnDecipher.Name = "BtnDecipher";
            this.BtnDecipher.Size = new System.Drawing.Size(191, 55);
            this.BtnDecipher.TabIndex = 3;
            this.BtnDecipher.Text = "Decipher";
            this.BtnDecipher.UseVisualStyleBackColor = true;
            this.BtnDecipher.Click += new System.EventHandler(this.BtnDecipher_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutput.Location = new System.Drawing.Point(23, 334);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(832, 382);
            this.TxtOutput.TabIndex = 6;
            // 
            // NupCodeValue
            // 
            this.NupCodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NupCodeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupCodeValue.Location = new System.Drawing.Point(735, 218);
            this.NupCodeValue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NupCodeValue.Name = "NupCodeValue";
            this.NupCodeValue.Size = new System.Drawing.Size(120, 45);
            this.NupCodeValue.TabIndex = 5;
            // 
            // BtnTryAll
            // 
            this.BtnTryAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTryAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTryAll.Location = new System.Drawing.Point(23, 212);
            this.BtnTryAll.Name = "BtnTryAll";
            this.BtnTryAll.Size = new System.Drawing.Size(191, 55);
            this.BtnTryAll.TabIndex = 2;
            this.BtnTryAll.Text = "Try All";
            this.BtnTryAll.UseVisualStyleBackColor = true;
            this.BtnTryAll.Click += new System.EventHandler(this.BtnTryAll_Click);
            // 
            // LblCipherNumber
            // 
            this.LblCipherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCipherNumber.AutoSize = true;
            this.LblCipherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCipherNumber.Location = new System.Drawing.Point(481, 220);
            this.LblCipherNumber.Name = "LblCipherNumber";
            this.LblCipherNumber.Size = new System.Drawing.Size(248, 39);
            this.LblCipherNumber.TabIndex = 4;
            this.LblCipherNumber.Text = "Cipher Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 745);
            this.Controls.Add(this.LblCipherNumber);
            this.Controls.Add(this.BtnTryAll);
            this.Controls.Add(this.NupCodeValue);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.BtnDecipher);
            this.Controls.Add(this.BtnEncipher);
            this.Controls.Add(this.TxtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(897, 784);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NupCodeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnEncipher;
        private System.Windows.Forms.Button BtnDecipher;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.NumericUpDown NupCodeValue;
        private System.Windows.Forms.Button BtnTryAll;
        private System.Windows.Forms.Label LblCipherNumber;
    }
}

