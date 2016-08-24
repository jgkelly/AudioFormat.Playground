namespace TestUI
{
    partial class chapterTestForm
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
            this.filePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.chapterList = new System.Windows.Forms.ListView();
            this.offsetValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&File Path:";
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(69, 12);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(423, 20);
            this.filePath.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.browseButton.Location = new System.Drawing.Point(498, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(96, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // chapterList
            // 
            this.chapterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.offsetValue,
            this.description});
            this.chapterList.Location = new System.Drawing.Point(15, 78);
            this.chapterList.Name = "chapterList";
            this.chapterList.Size = new System.Drawing.Size(749, 298);
            this.chapterList.TabIndex = 3;
            this.chapterList.UseCompatibleStateImageBehavior = false;
            this.chapterList.View = System.Windows.Forms.View.Details;
            // 
            // offsetValue
            // 
            this.offsetValue.Text = "Time Offset";
            this.offsetValue.Width = 183;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 557;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chapters";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // testButton
            // 
            this.testButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testButton.Location = new System.Drawing.Point(689, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "&Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // chapterTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 388);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chapterList);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Name = "chapterTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListView chapterList;
        private System.Windows.Forms.ColumnHeader offsetValue;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button testButton;
    }
}

