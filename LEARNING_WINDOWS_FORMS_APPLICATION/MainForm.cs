namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void displayDirectoriesAndFilesButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(pathTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show
					(text: "تکمیل مسیر الزامی است!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				pathTextBox.Text = string.Empty;

				pathTextBox.Focus();

				return;
			}

			pathTextBox.Text =
				pathTextBox.Text.Trim();

			if (System.IO.Directory.Exists(path: pathTextBox.Text) == false)
			{
				System.Windows.Forms.MessageBox.Show
					(text: "چنین مسیری وجود ندارد!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				pathTextBox.Focus();

				return;
			}

			DisplayDirectoriesAndFiles();
		}

		//private void DisplayDirectoriesAndFiles()
		//{
		//	try
		//	{
		//		System.IO.DirectoryInfo directoryInfo =
		//			new System.IO.DirectoryInfo(path: pathTextBox.Text);

		//		// **************************************************
		//		directorieslistBox.Items.Clear();

		//		foreach (System.IO.DirectoryInfo currentDirectoryInfo in directoryInfo.GetDirectories())
		//		{
		//			directorieslistBox.Items.Add(currentDirectoryInfo.Name);
		//		}
		//		// **************************************************

		//		// **************************************************
		//		filesListBox.Items.Clear();

		//		foreach (System.IO.FileInfo currentFileInfo in directoryInfo.GetFiles())
		//		{
		//			filesListBox.Items.Add(currentFileInfo.Name);
		//		}
		//		// **************************************************
		//	}
		//	catch (System.Exception ex)
		//	{
		//		System.Windows.Forms.MessageBox.Show(ex.Message);
		//	}
		//}

		private void directorieslistBox_DoubleClick(object sender, System.EventArgs e)
		{
			if (directorieslistBox.SelectedItem == null)
			{
				System.Windows.Forms.MessageBox.Show
					(text: "لطفا پوشه‌ای را انتخاب نمایید!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				directorieslistBox.Focus();

				return;
			}

			if (directorieslistBox.SelectedItem.ToString() != "..")
			{
				//pathTextBox.Text =
				//	string.Format(@"{0}\{1}",
				//	pathTextBox.Text, directorieslistBox.SelectedItem);

				pathTextBox.Text =
					$"{ pathTextBox.Text }\\{ directorieslistBox.SelectedItem }";
			}
			else
			{
				int index =
					pathTextBox.Text.LastIndexOf("\\");

				pathTextBox.Text =
					pathTextBox.Text.Substring(startIndex: 0, length: index);
			}

			DisplayDirectoriesAndFiles();
		}

		private void DisplayDirectoriesAndFiles()
		{
			// **************************************************
			string path = pathTextBox.Text;

			if (path.Length == 2)
			{
				path += "\\";
			}
			// **************************************************

			try
			{
				System.IO.DirectoryInfo directoryInfo =
					new System.IO.DirectoryInfo(path: path);

				// **************************************************
				directorieslistBox.Items.Clear();

				// اگر در داخل یک پوشه بودیم
				if (path.Length > 3)
				{
					directorieslistBox.Items.Add("..");
				}

				foreach (System.IO.DirectoryInfo currentDirectoryInfo in directoryInfo.GetDirectories())
				{
					directorieslistBox.Items.Add(currentDirectoryInfo.Name);
				}
				// **************************************************

				// **************************************************
				filesListBox.Items.Clear();

				foreach (System.IO.FileInfo currentFileInfo in directoryInfo.GetFiles())
				{
					filesListBox.Items.Add(currentFileInfo.Name);
				}
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}
	}
}
