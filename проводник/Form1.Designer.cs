namespace проводник
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewToolStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.PropertiesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.PropertiesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripButton,
            this.ForwardToolStripButton,
            this.toolStripSeparator1,
            this.UpToolStripButton,
            this.toolStripSeparator2,
            this.RefreshToolStripButton,
            this.toolStripSeparator3,
            this.ViewToolStripSplitButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1199, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton.Image = global::проводник.Properties.Resources.back;
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.BackToolStripButton.Text = "toolStripButton1";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // ForwardToolStripButton
            // 
            this.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardToolStripButton.Image = global::проводник.Properties.Resources.forward;
            this.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardToolStripButton.Name = "ForwardToolStripButton";
            this.ForwardToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.ForwardToolStripButton.Text = "toolStripButton2";
            this.ForwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // UpToolStripButton
            // 
            this.UpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UpToolStripButton.Image")));
            this.UpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpToolStripButton.Name = "UpToolStripButton";
            this.UpToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.UpToolStripButton.Text = "toolStripButton3";
            this.UpToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshToolStripButton.Image = global::проводник.Properties.Resources.refresh;
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.RefreshToolStripButton.Text = "toolStripButton4";
            this.RefreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // ViewToolStripSplitButton
            // 
            this.ViewToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListToolStripMenuItem,
            this.TableToolStripMenuItem,
            this.TileToolStripMenuItem,
            this.LargeIconsToolStripMenuItem,
            this.SmallIconsToolStripMenuItem});
            this.ViewToolStripSplitButton.Image = global::проводник.Properties.Resources.view;
            this.ViewToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewToolStripSplitButton.Name = "ViewToolStripSplitButton";
            this.ViewToolStripSplitButton.Size = new System.Drawing.Size(42, 28);
            this.ViewToolStripSplitButton.Text = "toolStripSplitButton1";
            // 
            // ListToolStripMenuItem
            // 
            this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
            this.ListToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.ListToolStripMenuItem.Text = "Список";
            this.ListToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.TableToolStripMenuItem.Text = "Таблица";
            this.TableToolStripMenuItem.Click += new System.EventHandler(this.TableToolStripMenuItem_Click);
            // 
            // TileToolStripMenuItem
            // 
            this.TileToolStripMenuItem.Name = "TileToolStripMenuItem";
            this.TileToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.TileToolStripMenuItem.Text = "Плитка";
            this.TileToolStripMenuItem.Click += new System.EventHandler(this.TileToolStripMenuItem_Click);
            // 
            // LargeIconsToolStripMenuItem
            // 
            this.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem";
            this.LargeIconsToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.LargeIconsToolStripMenuItem.Text = "Большие значки";
            this.LargeIconsToolStripMenuItem.Click += new System.EventHandler(this.LargeIconsToolStripMenuItem_Click);
            // 
            // SmallIconsToolStripMenuItem
            // 
            this.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem";
            this.SmallIconsToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.SmallIconsToolStripMenuItem.Text = "Обычные значки";
            this.SmallIconsToolStripMenuItem.Click += new System.EventHandler(this.SmallIconsToolStripMenuItem_Click);
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Location = new System.Drawing.Point(0, 33);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(264, 778);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // listView
            // 
            this.listView.ContextMenuStrip = this.PropertiesContextMenuStrip;
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(264, 33);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(935, 778);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // PropertiesContextMenuStrip
            // 
            this.PropertiesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PropertiesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropToolStripMenuItem});
            this.PropertiesContextMenuStrip.Name = "contextMenuStrip1";
            this.PropertiesContextMenuStrip.Size = new System.Drawing.Size(161, 36);
            // 
            // PropToolStripMenuItem
            // 
            this.PropToolStripMenuItem.Name = "PropToolStripMenuItem";
            this.PropToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.PropToolStripMenuItem.Text = "Свойства";
            this.PropToolStripMenuItem.Click += new System.EventHandler(this.PropToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 811);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.PropertiesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripButton ForwardToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton UpToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ViewToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem ListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LargeIconsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ContextMenuStrip PropertiesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallIconsToolStripMenuItem;
    }
}

