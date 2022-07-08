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
            this.BtnReadJSONFile = new System.Windows.Forms.Button();
            this.RichTxtBoxJSONFile = new System.Windows.Forms.RichTextBox();
            this.BtnGenerateResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadJSONFile
            // 
            this.BtnReadJSONFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReadJSONFile.Location = new System.Drawing.Point(21, 19);
            this.BtnReadJSONFile.Name = "BtnReadJSONFile";
            this.BtnReadJSONFile.Size = new System.Drawing.Size(142, 29);
            this.BtnReadJSONFile.TabIndex = 0;
            this.BtnReadJSONFile.Text = "Read JSON File";
            this.BtnReadJSONFile.UseVisualStyleBackColor = true;
            this.BtnReadJSONFile.Click += new System.EventHandler(this.BtnReadJSONFile_Click);
            // 
            // RichTxtBoxJSONFile
            // 
            this.RichTxtBoxJSONFile.Location = new System.Drawing.Point(21, 54);
            this.RichTxtBoxJSONFile.Name = "RichTxtBoxJSONFile";
            this.RichTxtBoxJSONFile.Size = new System.Drawing.Size(502, 247);
            this.RichTxtBoxJSONFile.TabIndex = 2;
            this.RichTxtBoxJSONFile.Text = "";
            // 
            // BtnGenerateResume
            // 
            this.BtnGenerateResume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerateResume.Location = new System.Drawing.Point(21, 307);
            this.BtnGenerateResume.Name = "BtnGenerateResume";
            this.BtnGenerateResume.Size = new System.Drawing.Size(159, 29);
            this.BtnGenerateResume.TabIndex = 3;
            this.BtnGenerateResume.Text = "Generate Resume";
            this.BtnGenerateResume.UseVisualStyleBackColor = true;
            // 
            // PDFResumeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 363);
            this.Controls.Add(this.BtnGenerateResume);
            this.Controls.Add(this.RichTxtBoxJSONFile);
            this.Controls.Add(this.BtnReadJSONFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PDFResumeGeneratorForm";
            this.Text = "PDF Resume Generator";
            this.Load += new System.EventHandler(this.PDFResumeGeneratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnReadJSONFile;
        private RichTextBox RichTxtBoxJSONFile;
        private Button BtnGenerateResume;
    }
}