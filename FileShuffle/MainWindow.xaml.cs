using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileShuffle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Shuffle Files");
            key.SetValue("Shuffle", "Files");
            InitializeComponent();
        }

        private void shuffleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                $"Are you sure you want to rename all the files in {filepathTextBox.Text}?",
                "Warning",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes && Directory.Exists(filepathTextBox.Text))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(filepathTextBox.Text);
                var fileNames = directoryInfo.GetFiles().ToList();
                randomRename(fileNames);
            }
            else if (!Directory.Exists(filepathTextBox.Text))
            {
                MessageBoxResult error = MessageBox.Show(
                $"Error finding directory: {filepathTextBox.Text}"
                + "\nTry using the 'Browse' directory button.",
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }

        private void randomRename(List<FileInfo> files)
        {
            var rand = new Random();
            var fileDictionary = files.ToDictionary(x => x.FullName, x => x.Name);

            foreach (FileInfo fi in files)
            {
                bool renameSuccess = false;
                while (!renameSuccess)
                {
                    var filePath = fi.FullName.Replace(fi.Name, "");
                    var newFileName = $"{rand.Next(0, 1000000).ToString("X8")}{fi.Extension}";
                    filePath += newFileName;
                    try
                    {
                        if (fileDictionary.TryAdd(filePath, fi.Name))
                        {
                            fileDictionary.Remove(fi.FullName);
                            fi.MoveTo(filePath);
                            renameSuccess = true;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBoxResult error = MessageBox.Show(
                            e.Message,
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                        break;
                    }
                }
            }

            MessageBoxResult processingCompleteMessage = MessageBox.Show(
                "Shuffle Complete. ",
                "Done",
                MessageBoxButton.OK,
                MessageBoxImage.None);

        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Multiselect = false;
            dialog.EnsurePathExists = true;
            dialog.AllowNonFileSystemItems = true;
            CommonFileDialogResult result = dialog.ShowDialog();

            if (result == CommonFileDialogResult.Ok && !String.IsNullOrEmpty(dialog.FileName))
            {
                filepathTextBox.Text = dialog.FileName;
            }

            dialog.Dispose();
        }
    }
}
