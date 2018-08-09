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
		//		directoriesListBox.Items.Clear();

		//		foreach (System.IO.DirectoryInfo currentDirectoryInfo in directoryInfo.GetDirectories())
		//		{
		//			directoriesListBox.Items.Add(currentDirectoryInfo.Name);
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

		private void DisplayDirectoriesAndFiles()
		{
			// **************************************************
			string path =
				pathTextBox.Text;

			switch (path.Length)
			{
				case 0:
				{
					return;
				}

				case 1:
				{
					path += @":\";
					break;
				}

				case 2:
				{
					path += @"\";
					break;
				}
			}
			// **************************************************

			try
			{
				System.IO.DirectoryInfo directoryInfo =
					new System.IO.DirectoryInfo(path: path);

				// **************************************************
				directoriesListBox.Items.Clear();

				// اگر در داخل یک پوشه بودیم
				if (path.Length > 3)
				{
					directoriesListBox.Items.Add("..");
				}

				foreach (System.IO.DirectoryInfo currentDirectoryInfo in directoryInfo.GetDirectories())
				{
					directoriesListBox.Items.Add(currentDirectoryInfo.Name);
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

		private void directorieslistBox_DoubleClick(object sender, System.EventArgs e)
		{
			if (directoriesListBox.SelectedItem == null)
			{
				System.Windows.Forms.MessageBox.Show
					(text: "لطفا پوشه‌ای را انتخاب نمایید!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				directoriesListBox.Focus();

				return;
			}

			if (directoriesListBox.SelectedItem.ToString() != "..")
			{
				//pathTextBox.Text =
				//	string.Format(@"{0}\{1}",
				//	pathTextBox.Text, directorieslistBox.SelectedItem);

				//pathTextBox.Text =
				//	$"{ pathTextBox.Text }\\{ directoriesListBox.SelectedItem }";

				if (pathTextBox.Text.EndsWith(@"\"))
				{
					pathTextBox.Text =
						$"{ pathTextBox.Text }{ directoriesListBox.SelectedItem }";
				}
				else
				{
					pathTextBox.Text =
						$"{ pathTextBox.Text }\\{ directoriesListBox.SelectedItem }";
				}
			}
			else
			{
				//int index =
				//	pathTextBox.Text.LastIndexOf("\\");

				int index =
					pathTextBox.Text.LastIndexOf(@"\");

				pathTextBox.Text =
					pathTextBox.Text.Substring(startIndex: 0, length: index);

				if (pathTextBox.Text.Length == 2)
				{
					pathTextBox.Text += @"\";
				}
			}

			DisplayDirectoriesAndFiles();
		}
	}
}
