using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проводник
{
    public partial class Prop : Form
    {
        Icon icon;
        public Prop(string directoryPath)
        {
            InitializeComponent();

            try {

                FileInfo file = new FileInfo(directoryPath);

                if (file.FullName.Length <= 3)
                {
                    DriveInfo drv = new System.IO.DriveInfo(directoryPath);

                    icon = new Icon(@"../../CLSDFOLD.ICO");
                    pictureBox1.Image = icon.ToBitmap();

                    Text += drv.Name;

                    label8.Text = "Диск";

                    textBox1.Text = drv.Name;

                    label9.Text = drv.Name;

                    if (drv.IsReady)
                    {
                        label10.Text = ((drv.TotalSize / 1024 / 1024) - (drv.AvailableFreeSpace / 1024 / 1024)).ToString() + " МБ";
                    }
                }

                else if (file.Attributes.HasFlag(FileAttributes.Directory))
                {
                    DirectoryInfo directory = new DirectoryInfo(directoryPath);

                    icon = new Icon(@"../../CLSDFOLD.ICO");
                    pictureBox1.Image = icon.ToBitmap();

                    Text += file.Name;

                    textBox1.Text = directory.FullName;

                    label8.Text = "Папка";

                    long size = 0;

                    foreach (FileInfo files in directory.GetFiles("*", SearchOption.AllDirectories))
                    {
                        size += files.Length;
                    }
                    if ((size / 1024) == 0)
                    {
                        label10.Text = size.ToString() + " КБ";
                    }
                    else
                    {
                        label10.Text = (size / 1024).ToString() + " МБ";
                    }

                    label9.Text = file.DirectoryName;
                }
                else
                {
                    FileVersionInfo fileInfo = FileVersionInfo.GetVersionInfo(directoryPath);
                    icon = Icon.ExtractAssociatedIcon(directoryPath);
                    pictureBox1.Image = icon.ToBitmap();

                    Text += file.Name;

                    textBox1.Text = fileInfo.FileName;

                    label8.Text = "Файл ";

                    if (fileInfo.FileDescription != null)
                    {
                        label8.Text += fileInfo.FileDescription;
                    }
                    else
                    {
                        label8.Text += file.Extension;
                    }
                    if ((file.Length / 1024) == 0)
                    {
                        label10.Text = (file.Length).ToString() + " КБ";
                    }
                    else
                    {
                        label10.Text = (file.Length / 1024).ToString() + " МБ";
                    }

                    label9.Text = file.DirectoryName;
                }

                Icon = icon;

                if (file.IsReadOnly == true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }


                label4.Text = file.CreationTimeUtc.ToString();

                label13.Text = file.LastWriteTimeUtc.ToString();

                label14.Text = file.LastAccessTimeUtc.ToString();

            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
    }
}
