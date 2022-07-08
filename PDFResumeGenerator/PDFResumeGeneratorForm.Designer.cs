namespace PDFResumeGenerator
{
    partial class PDFResumeGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFResumeGeneratorForm));
            this.RichTxtBoxJSONFile = new System.Windows.Forms.RichTextBox();
            this.BtnGenerateResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTxtBoxJSONFile
            // 
            this.RichTxtBoxJSONFile.Location = new System.Drawing.Point(24, 72);
            this.RichTxtBoxJSONFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RichTxtBoxJSONFile.Name = "RichTxtBoxJSONFile";
            this.RichTxtBoxJSONFile.Size = new System.Drawing.Size(573, 328);
            this.RichTxtBoxJSONFile.TabIndex = 2;
            this.RichTxtBoxJSONFile.Text = "";
            // 
            // BtnGenerateResume
            // 
            this.BtnGenerateResume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerateResume.Location = new System.Drawing.Point(24, 409);
            this.BtnGenerateResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGenerateResume.Name = "BtnGenerateResume";
            this.BtnGenerateResume.Size = new System.Drawing.Size(199, 39);
            this.BtnGenerateResume.TabIndex = 3;
            this.BtnGenerateResume.Text = "Generate Resume";
            this.BtnGenerateResume.UseVisualStyleBackColor = true;
            this.BtnGenerateResume.Click += new System.EventHandler(this.BtnGenerateResume_Click);
            // 
            // PDFResumeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 484);
            this.Controls.Add(this.BtnGenerateResume);
            this.Controls.Add(this.RichTxtBoxJSONFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PDFResumeGeneratorForm";
            this.Text = "PDF Resume Generator";
            this.Load += new System.EventHandler(this.PDFResumeGeneratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox RichTxtBoxJSONFile;
        private Button BtnGenerateResume;
    }
}