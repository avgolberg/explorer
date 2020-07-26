using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace проводник
{
    public partial class Form1 : Form
    {
        ImageList imageList;
        ImageList image_list1 = new ImageList(); // список изображений для хранения малых значков
        ImageList image_list2 = new ImageList(); // список изображений для хранения больших значков

        string directoryPath;
        string propPath;
        string directoryPathForward;

        string directoryDrive;
        string directoryDriveForward;
        
        string[] drives;
        public Form1()
        {
            InitializeComponent();

            imageList = new ImageList();
            imageList.Images.Add(Bitmap.FromFile(@"..\..\Resources\folder.png"));
            treeView.ImageList = imageList;
            treeView.ItemHeight = 20;

            image_list1.ImageSize = new Size(16, 16);
            image_list2.ImageSize = new Size(32, 32);

            listView.SmallImageList = image_list1;
            listView.LargeImageList = image_list2;

            //колонки для вида "Таблица"
            listView.Columns.Add("Имя файла", 230);
            listView.Columns.Add("Дата изменения", 120);
            listView.Columns.Add("Размер", 85);

            ForwardToolStripButton.Enabled = false;

            drives = Directory.GetLogicalDrives();
            for (int x = 0; x < drives.Length; ++x)
            {
                // Добавляем корневой узел
                TreeNode node = new TreeNode();

                node.ImageIndex = 0; //иконка в невыбранном состоянии
                node.SelectedImageIndex = 0; //иконка в выбранном состоянии

                node.Text = drives[x].Remove(drives[x].Length - 1);

                node.Name = drives[x].Remove(drives[x].Length - 1);

                treeView.Nodes.Add(node);

                AddDirectories(node);
            }

            directoryPath = drives[0];
            directoryDrive = drives[0];
            directoryDriveForward = drives[0];
            directoryPathForward = drives[0];
        }
        void AddDirectories(TreeNode node)
        {
            // Для текущего узла node получаем полный путь к корню дерева
            string strPath = node.FullPath + "//";
            // Создаем объект текущего каталога
            DirectoryInfo dirInfo = new DirectoryInfo(strPath);
            // Объявляем ссылку на массив подкаталогов текущего каталога
            DirectoryInfo[] arrayDirInfo;

            //нужно доп. условие, чтобы не было исключений про то, что нет доступа к каталогу (чтобы приложение быстрее запускалось)

                try
                {
                    // Пытаемся получить список подкаталогов
                    arrayDirInfo = dirInfo.GetDirectories();
                }
                catch
                {
                    // Подкаталогов нет, выходим из рекурсии
                    return;
                }

                // Добавляем прочитанные подкаталоги как узлы в дерево просмотра
                foreach (DirectoryInfo dir in arrayDirInfo)
                {
                    // Создаем новый узел с именем подкаталога
                    TreeNode nodeDir = new TreeNode(dir.Name);
                    nodeDir.Name = dir.Name;

                    // Добавляем его как дочерний к текущему узлу
                    node.Nodes.Add(nodeDir);

                    // Делаем дочерний узел текущим и спускаемся рекурсивно ниже
                    AddDirectories(nodeDir);
                }
        }
        void FillListView()
        {
            //текущий диск
            try
            {
                directoryDrive = directoryPath.Remove(3);
            }
            catch(Exception)
            {
                directoryDrive = (string)directoryDrive.Clone();
            }

            //Доступна ли кнопка "Вперед"
            if (directoryPath == directoryPathForward || directoryDrive != directoryDriveForward)
            {
                directoryDriveForward = (string)directoryDrive.Clone();
                ForwardToolStripButton.Enabled = false;
            }
            else
            {
                ForwardToolStripButton.Enabled = true;
            }

            listView.Items.Clear();
            image_list1.Images.Clear();
            image_list2.Images.Clear();

            try
            {
                string[] tableParameters = new string[3]; //для вида "Таблица"
                string[] files = Directory.GetFiles(directoryPath);
                string[] directories = Directory.GetDirectories(directoryPath);

                Icon icon = new Icon(@"../../CLSDFOLD.ICO");

                image_list1.Images.Add(icon);
                image_list2.Images.Add(icon);

                foreach (string dir in directories)
                {
                    string fileName = dir.Remove(0, directoryPath.Length);

                    if (fileName.StartsWith("\\"))
                    {
                        fileName = fileName.Remove(fileName.IndexOf("\\"), 1);
                    }

                    if (listView.View == View.Details)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(dir);

                        try
                        {
                            tableParameters[0] = directoryInfo.Name;
                            tableParameters[1] = directoryInfo.LastWriteTimeUtc.ToString();

                            long size = 0; //узнаем размер папки, складывая размеры ее содержимого
                            foreach (FileInfo fi in directoryInfo.GetFiles("*", SearchOption.AllDirectories))
                            {
                                size += fi.Length;
                            }

                            if ((size / 1024) == 0)
                            {
                                tableParameters[2] = size.ToString() + " КБ";
                            }
                            else
                            {
                                tableParameters[2] = (size / 1024).ToString() + " МБ";
                            }

                            ListViewItem item = new ListViewItem(tableParameters, 0);
                            listView.Items.Add(item);
                        }
                        catch (Exception)
                        {
                            ListViewItem item = new ListViewItem(directoryInfo.Name, 0);
                            listView.Items.Add(item);
                        }
                    }
                    else
                    {
                        listView.Items.Add(fileName, 0);
                    }
                }

                int index = 1;
                foreach (string file in files)
                {
                    icon = Icon.ExtractAssociatedIcon(file);
                    image_list1.Images.Add(icon);
                    image_list2.Images.Add(icon);

                    string fileName = file.Remove(0, directoryPath.Length);
                    if (fileName.StartsWith("\\"))
                    {
                        fileName = fileName.Remove(fileName.IndexOf("\\"), 1);
                    }

                    if (listView.View == View.Details)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        try
                        {
                            tableParameters[0] = fileInfo.Name;
                            tableParameters[1] = fileInfo.LastWriteTimeUtc.ToString();

                            if ((file.Length / 1024) == 0)
                            {
                                tableParameters[2] = fileInfo.Length.ToString() + " КБ";
                            }
                            else
                            {
                                tableParameters[2] = (fileInfo.Length / 1024).ToString() + " МБ";
                            }

                            ListViewItem item = new ListViewItem(tableParameters, index++);
                            listView.Items.Add(item);
                        }
                        catch (Exception)
                        {
                            ListViewItem item = new ListViewItem(fileInfo.Name, 0);
                            listView.Items.Add(item);
                        }
                    }
                    else
                    {
                        listView.Items.Add(fileName, index++);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listView.SelectedItems[0];
                if (item != null)
                {
                   
                    if (File.GetAttributes(directoryPath + "\\" + item.Text).HasFlag(FileAttributes.Directory))
                    {
                        if (directoryPath.Length > 3)
                        {
                            directoryPath += "\\" + item.Text;
                            directoryDriveForward = directoryPath.Remove(3);
                        }
                        else
                        {
                            directoryPath += item.Text;
                            directoryDriveForward = (string)directoryPath.Clone();
                        }

                        directoryPathForward = (string)directoryPath.Clone();
                        FillListView();

                        //раскрываем точно правильный каталог
                        DirectoryInfo directoryInfo;
                        string tempDirectoryPath = (string)directoryPath.Clone();
                        if (tempDirectoryPath.Remove(tempDirectoryPath.Length - item.Text.Length).Length > 3)
                        {
                            directoryInfo = new DirectoryInfo(tempDirectoryPath.Remove(tempDirectoryPath.LastIndexOf("\\"), 1));
                            tempDirectoryPath = tempDirectoryPath.Remove(tempDirectoryPath.LastIndexOf("\\"), 1);
                        }
                        else
                        {
                            directoryInfo = new DirectoryInfo(tempDirectoryPath);
                        }

                        string dirRoot = directoryInfo.Root.ToString();
                        string dirName = directoryInfo.Name;
                        string temp = "";

                        TreeNode[] root = treeView.Nodes.Find(dirRoot.Remove(dirRoot.LastIndexOf("\\")), false); //раскрываем диск, в нем ищем папку
                        treeView.SelectedNode = root[0];
                        TreeNode tempNode = root[0];
                        TreeNode[] root2;
                        try
                        {
                            tempDirectoryPath = tempDirectoryPath.Remove(0, 3);
                            temp = (string)tempDirectoryPath.Clone();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        while (temp != dirName)
                        {
                            if (tempDirectoryPath.StartsWith("\\"))
                            {
                                tempDirectoryPath = tempDirectoryPath.Remove(tempDirectoryPath.IndexOf("\\"), 1);
                                temp = (string)tempDirectoryPath.Clone();
                            }

                            if (tempDirectoryPath.IndexOf("\\") != -1)
                            {
                                temp = tempDirectoryPath.Remove(tempDirectoryPath.IndexOf("\\")); //получили имя первой подпапки
                                tempDirectoryPath = tempDirectoryPath.Remove(0, tempDirectoryPath.IndexOf("\\"));
                            }

                            root2 = treeView.SelectedNode.Nodes.Find(temp, false);
                            treeView.SelectedNode = root2[0];
                            treeView.SelectedNode.Expand();
                        }
                        if (treeView.SelectedNode == tempNode)
                        {
                            treeView.SelectedNode.Expand();
                        }
                    }
                    else
                    {
                        Process.Start(directoryPath + "\\" + item.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeView treeView = sender as TreeView;
                directoryPath = treeView.SelectedNode.FullPath + "\\";
                if (directoryPath.Length > 3)
                {
                    directoryDriveForward = directoryPath.Remove(3);
                }
                else
                {
                    directoryDriveForward = (string)directoryPath.Clone();
                }
                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            if (directoryPath.Remove(directoryPath.LastIndexOf("\\")).Length < 3)
            {
                FillListView();
            }
            else
            {
                if (directoryPath.EndsWith("\\"))
                {
                    directoryPath = directoryPath.Remove(directoryPath.LastIndexOf("\\"));
                }
            }

            FileInfo file = new FileInfo(directoryPath);
            try
            {
                directoryPath = directoryPath.Remove(directoryPath.Length - file.Name.Length);
                FillListView();
            }
            catch (Exception)
            {
                FillListView();
            }
        }
      
        private void ForwardToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = (string)directoryPathForward.Clone();
                temp = temp.Remove(0, directoryPath.Length);
                if (temp.StartsWith("\\") == false)
                {
                    try
                    {
                        temp = temp.Remove(temp.IndexOf("\\"));
                    }
                    catch (Exception)
                    {
                    }
                }
                directoryPath += temp;
                FillListView();
            }
            catch (Exception)
            {
                FillListView();
            }
        }
        private void PropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView.SelectedItems[0];
                if (directoryPath.Remove(directoryPath.Length - item.Name.Length - 1).Length > 3)
                {
                    propPath = directoryPath + "\\" + item.Text;
                }
                else
                {
                    propPath = directoryPath + item.Text;
                }
            }
            catch (Exception)
            {
                propPath = directoryPath;
            }
            Prop propertiesForm = new Prop(propPath);
            try
            {
                propertiesForm.Show();
            }
            catch (Exception)
            {
            }
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.GridLines = true;
            listView.View = View.Details;

            FillListView();
        }

        private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.List;

        }

        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.Tile;
        }
    }
}
