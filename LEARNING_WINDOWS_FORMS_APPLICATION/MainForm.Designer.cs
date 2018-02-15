namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.pathLabel = new System.Windows.Forms.Label();
			this.pathTextBox = new System.Windows.Forms.TextBox();
			this.displayDirectoriesAndFilesButton = new System.Windows.Forms.Button();
			this.directorieslistBox = new System.Windows.Forms.ListBox();
			this.filesListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// pathLabel
			// 
			this.pathLabel.AutoSize = true;
			this.pathLabel.Location = new System.Drawing.Point(12, 15);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(38, 16);
			this.pathLabel.TabIndex = 0;
			this.pathLabel.Text = "&Path";
			// 
			// pathTextBox
			// 
			this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathTextBox.Location = new System.Drawing.Point(56, 12);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.Size = new System.Drawing.Size(365, 23);
			this.pathTextBox.TabIndex = 1;
			this.pathTextBox.Text = "C:\\Windows";
			// 
			// displayDirectoriesAndFilesButton
			// 
			this.displayDirectoriesAndFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.displayDirectoriesAndFilesButton.Location = new System.Drawing.Point(427, 12);
			this.displayDirectoriesAndFilesButton.Name = "displayDirectoriesAndFilesButton";
			this.displayDirectoriesAndFilesButton.Size = new System.Drawing.Size(75, 23);
			this.displayDirectoriesAndFilesButton.TabIndex = 2;
			this.displayDirectoriesAndFilesButton.Text = "...";
			this.displayDirectoriesAndFilesButton.UseVisualStyleBackColor = true;
			this.displayDirectoriesAndFilesButton.Click += new System.EventHandler(this.displayDirectoriesAndFilesButton_Click);
			// 
			// directorieslistBox
			// 
			this.directorieslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.directorieslistBox.FormattingEnabled = true;
			this.directorieslistBox.ItemHeight = 16;
			this.directorieslistBox.Location = new System.Drawing.Point(12, 41);
			this.directorieslistBox.Name = "directorieslistBox";
			this.directorieslistBox.Size = new System.Drawing.Size(490, 148);
			this.directorieslistBox.TabIndex = 3;
			this.directorieslistBox.DoubleClick += new System.EventHandler(this.directorieslistBox_DoubleClick);
			// 
			// filesListBox
			// 
			this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filesListBox.FormattingEnabled = true;
			this.filesListBox.ItemHeight = 16;
			this.filesListBox.Location = new System.Drawing.Point(12, 195);
			this.filesListBox.Name = "filesListBox";
			this.filesListBox.Size = new System.Drawing.Size(490, 132);
			this.filesListBox.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(514, 361);
			this.Controls.Add(this.filesListBox);
			this.Controls.Add(this.directorieslistBox);
			this.Controls.Add(this.displayDirectoriesAndFilesButton);
			this.Controls.Add(this.pathTextBox);
			this.Controls.Add(this.pathLabel);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(530, 400);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pathLabel;
		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.Button displayDirectoriesAndFilesButton;
		private System.Windows.Forms.ListBox directorieslistBox;
		private System.Windows.Forms.ListBox filesListBox;
	}
}
