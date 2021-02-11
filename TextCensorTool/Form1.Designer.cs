namespace TextCensorTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.originalText = new System.Windows.Forms.TextBox();
            this.censoredText = new System.Windows.Forms.TextBox();
            this.CensorBtn = new System.Windows.Forms.Button();
            this.itemToCensorTxt = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.useNewBtn = new System.Windows.Forms.Button();
            this.blackBarRadio = new System.Windows.Forms.RadioButton();
            this.redactedRadio = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Censored";
            // 
            // originalText
            // 
            this.originalText.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalText.Location = new System.Drawing.Point(12, 46);
            this.originalText.Multiline = true;
            this.originalText.Name = "originalText";
            this.originalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalText.Size = new System.Drawing.Size(446, 524);
            this.originalText.TabIndex = 2;
            // 
            // censoredText
            // 
            this.censoredText.Enabled = false;
            this.censoredText.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.censoredText.Location = new System.Drawing.Point(464, 46);
            this.censoredText.Multiline = true;
            this.censoredText.Name = "censoredText";
            this.censoredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.censoredText.Size = new System.Drawing.Size(446, 524);
            this.censoredText.TabIndex = 3;
            // 
            // CensorBtn
            // 
            this.CensorBtn.Enabled = false;
            this.CensorBtn.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CensorBtn.Location = new System.Drawing.Point(464, 576);
            this.CensorBtn.Name = "CensorBtn";
            this.CensorBtn.Size = new System.Drawing.Size(130, 33);
            this.CensorBtn.TabIndex = 4;
            this.CensorBtn.Text = "Censor This";
            this.CensorBtn.UseVisualStyleBackColor = true;
            this.CensorBtn.Click += new System.EventHandler(this.CensorBtn_Click);
            // 
            // itemToCensorTxt
            // 
            this.itemToCensorTxt.Enabled = false;
            this.itemToCensorTxt.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemToCensorTxt.Location = new System.Drawing.Point(601, 577);
            this.itemToCensorTxt.Name = "itemToCensorTxt";
            this.itemToCensorTxt.Size = new System.Drawing.Size(309, 32);
            this.itemToCensorTxt.TabIndex = 5;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Red;
            this.resetBtn.Enabled = false;
            this.resetBtn.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetBtn.Location = new System.Drawing.Point(464, 615);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(130, 33);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.Location = new System.Drawing.Point(12, 576);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(223, 33);
            this.openFileBtn.TabIndex = 7;
            this.openFileBtn.Text = "Import Text File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Enabled = false;
            this.saveFileBtn.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileBtn.Location = new System.Drawing.Point(12, 615);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(446, 33);
            this.saveFileBtn.TabIndex = 8;
            this.saveFileBtn.Text = "Save Censored in New Text File";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // useNewBtn
            // 
            this.useNewBtn.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useNewBtn.Location = new System.Drawing.Point(235, 576);
            this.useNewBtn.Name = "useNewBtn";
            this.useNewBtn.Size = new System.Drawing.Size(223, 33);
            this.useNewBtn.TabIndex = 9;
            this.useNewBtn.Text = "Use Text You\'ve Entered";
            this.useNewBtn.UseVisualStyleBackColor = true;
            this.useNewBtn.Click += new System.EventHandler(this.useNewBtn_Click);
            // 
            // blackBarRadio
            // 
            this.blackBarRadio.AutoSize = true;
            this.blackBarRadio.Checked = true;
            this.blackBarRadio.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackBarRadio.Location = new System.Drawing.Point(633, 619);
            this.blackBarRadio.Name = "blackBarRadio";
            this.blackBarRadio.Size = new System.Drawing.Size(93, 23);
            this.blackBarRadio.TabIndex = 10;
            this.blackBarRadio.TabStop = true;
            this.blackBarRadio.Text = "██████";
            this.blackBarRadio.UseVisualStyleBackColor = true;
            // 
            // redactedRadio
            // 
            this.redactedRadio.AutoSize = true;
            this.redactedRadio.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redactedRadio.Location = new System.Drawing.Point(754, 619);
            this.redactedRadio.Name = "redactedRadio";
            this.redactedRadio.Size = new System.Drawing.Size(122, 23);
            this.redactedRadio.TabIndex = 11;
            this.redactedRadio.Text = "*REDACTED*";
            this.redactedRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 658);
            this.Controls.Add(this.redactedRadio);
            this.Controls.Add(this.blackBarRadio);
            this.Controls.Add(this.useNewBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.itemToCensorTxt);
            this.Controls.Add(this.CensorBtn);
            this.Controls.Add(this.censoredText);
            this.Controls.Add(this.originalText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Paul\'s Simple Censor Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox originalText;
        private System.Windows.Forms.TextBox censoredText;
        private System.Windows.Forms.Button CensorBtn;
        private System.Windows.Forms.TextBox itemToCensorTxt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button useNewBtn;
        private System.Windows.Forms.RadioButton blackBarRadio;
        private System.Windows.Forms.RadioButton redactedRadio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

