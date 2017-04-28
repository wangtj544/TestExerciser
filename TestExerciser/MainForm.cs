using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;



namespace TestExerciser
{
    public partial class MainForm : Form
    {
        string openProjectPath = "";
        public MainForm()
        {
            InitializeComponent();
            if ((tree_Solution.SelectedNode == null))
            {
                this.KeyPreview = false;
                删除ToolStripMenuItem.Visible = false;
                标识ToolStripMenuItem.Visible = false;
                打开文件路径ToolStripMenuItem.Visible = false;
                执行工程ToolStripMenuItem.Visible = false;
                执行测试套ToolStripMenuItem.Visible = false;
                刷新ToolStripMenuItem.Visible = false;
                重命名ToolStripMenuItem.Visible = false;
                闭合CToolStripMenuItem.Visible = false;
                展开EToolStripMenuItem.Visible = false;
                
            }
            else
            {
                删除ToolStripMenuItem.Visible = true;
                标识ToolStripMenuItem.Visible = true;
                打开文件路径ToolStripMenuItem.Visible = true;
                执行工程ToolStripMenuItem.Visible = true;
                执行测试套ToolStripMenuItem.Visible = true;
                刷新ToolStripMenuItem.Visible = true;
                重命名ToolStripMenuItem.Visible = true;
                闭合CToolStripMenuItem.Visible = true;
                展开EToolStripMenuItem.Visible = true;
            }       
            this.tabCodeEditor.TabPages.Clear();
        }

        public void 新建工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewProject new_Project = new NewProject();
                new_Project.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.ShowDialog() == DialogResult.OK)
            {
                this.KeyPreview = true;
                openProjectPath = selectProjectFolder.SelectedPath;
                getTreeViewData(openProjectPath);             
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((tree_Solution.SelectedNode == null) || (tree_Solution.SelectedNode.Text == null))
            {
                MessageBox.Show("请选择要删除的节点", "消息提示：");
            }
            else if (File.Exists(selectTreeNodeFullPath()))
            {
                try
                {
                    File.Delete(selectTreeNodeFullPath());
                    tree_Solution.SelectedNode.Remove();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString(), "异常消息提示：");
                }
            }
            else
            {
                if (!tree_Solution.SelectedNode.FullPath.Contains("\\"))
                {
                    DialogResult deleteFolder = MessageBox.Show("确定要移除工程吗？", "消息提示：", MessageBoxButtons.YesNo);
                    tree_Solution.SelectedNode.Remove();
                }
                else
                {
                    try
                    {
                        DialogResult deleteFolder = MessageBox.Show("确定要删除所选内容？", "消息提示：", MessageBoxButtons.YesNo);
                        if (deleteFolder == DialogResult.Yes)
                        {
                            delectDir(selectTreeNodeFullPath());
                            Directory.Delete(selectTreeNodeFullPath());
                            this.tree_Solution.SelectedNode.Remove();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "异常消息提示：");
                    }
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightClickOnProManager.Close();
        }

        private void 红ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tree_Solution.SelectedNode != null)
            {
                tree_Solution.SelectedNode.BackColor = Color.Red;
            }
            else
            {
                toolTips.Show("请左键选中相应的节点", this.rightClickOnProManager);
                toolTips.AutoPopDelay = 10;
                toolTips.UseFading = true;

            }

        }

        private void 黄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Yellow;
        }

        private void 蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Blue;
        }

        private void 绿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.SpringGreen;
        }

        private void 紫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Purple;
        }

        private void 粉ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Pink;
        }

        private void 默认DToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 执行工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rootFolder = selectProjectFolder.SelectedPath;
                writeRunSupportFile(rootFolder);
                runCmd("python.exe", @".\__runner.py");
                if (Directory.Exists(rootFolder + @"\.log"))
                {
                    string[] logFileName = Directory.GetFiles(rootFolder + @"\.log", "*.html");
                    logView.Navigate(logFileName[0]);
                }
                else
                {
                    MessageBox.Show("由于底层支撑库变更，log文件未生成！", "消息提示：");
                }
               
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }
            
        }

        private void 执行测试套ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(selectTreeNodeFullPath()))
            {
                DirectoryInfo folder = new DirectoryInfo(selectTreeNodeFullPath());
                DirectoryInfo[] chldFolders = folder.GetDirectories();
                FileInfo[] chldFiles = folder.GetFiles("*.*");
                foreach (FileInfo chlFile in chldFiles)
                foreach (DirectoryInfo chldFolder in chldFolders)
                {
                    if (chldFolder == null && chldFiles!=null)
                    {

                    }
                    else if (chldFolder == null && chldFiles == null)
                    {
                        MessageBox.Show("工程文件不存在，请添加工程文件！","消息提示：");
                    }
                    else 
                    {
                        MessageBox.Show("请选择正确的测试套！","消息提示：");
                    }
                }           
            }
        }

        private void 打开文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolderAndSelectFile(selectTreeNodeFullPath());
        }

        private void 新建文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.SelectedPath != null)
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   string [] openProjectPath = this.openFileDialog.SafeFileNames;
                }
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTreeViewData();
        }
      
        private void 打开文件FToolStripMenu_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.SelectedPath != null)
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string openFile = this.openFileDialog.SafeFileName;
                    string openFilePath = this.openFileDialog.FileName;

                    try
                    {
                        RichTextBox richTextBox = new RichTextBox();
                        TabPage file_page = new TabPage();
                        tabCodeEditor.Controls.Add(file_page);
                        file_page.Name = openFile;
                        file_page.Text = openFile;
                        file_page.Controls.Add(richTextBox);
                        tabCodeEditor.SelectedTab = file_page;
                        richTextBox.Dock = DockStyle.Fill;
                        FileStream aFile = new FileStream(openFilePath.ToString(), FileMode.OpenOrCreate);
                        RichTextBoxStreamType streamType = new RichTextBoxStreamType();
                        string file_ext = openFilePath.Substring(openFilePath.LastIndexOf('.') + 1);
                        switch (file_ext)
                        {
                            case "txt":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "py":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "ts":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "tc":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "xml":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "html":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            default:
                                streamType = RichTextBoxStreamType.PlainText; break;
                        }
                        richTextBox.LoadFile(aFile, streamType);
                        aFile.Dispose();
                        richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "异常消息提示：");
                    }
                }
            }
        }       

        private void 新建文件夹PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.SelectedPath != null)
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string openFile = this.openFileDialog.SafeFileName;
                    string openFilePath = this.openFileDialog.FileName;

                    try
                    {
                        RichTextBox richTextBox = new RichTextBox();
                        TabPage file_page = new TabPage();
                        tabCodeEditor.Controls.Add(file_page);
                        file_page.Name = openFile;
                        file_page.Text = openFile;
                        file_page.Controls.Add(richTextBox);
                        tabCodeEditor.SelectedTab = file_page;
                        richTextBox.Dock = DockStyle.Fill;
                        FileStream aFile = new FileStream(openFilePath.ToString(), FileMode.OpenOrCreate);
                        RichTextBoxStreamType streamType = new RichTextBoxStreamType();
                        string file_ext = openFilePath.Substring(openFilePath.LastIndexOf('.') + 1);
                        switch (file_ext)
                        {
                            case "txt":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "py":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "ts":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "tc":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "xml":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            case "html":
                                streamType = RichTextBoxStreamType.PlainText; break;
                            default:
                                streamType = RichTextBoxStreamType.PlainText; break;
                        }
                        richTextBox.LoadFile(aFile, streamType);
                        aFile.Dispose();
                        richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "异常消息提示：");
                    }
                }
            }
        }

        private void 新建文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectTreeNodeFullPath()) == false)
            {
                newFileDialog.InitialDirectory = selectTreeNodeFullPath();
                if (newFileDialog.ShowDialog() == DialogResult.OK)
                {
                    refreshTreeViewData();
                }
            }
            else
            {
                MessageBox.Show("请选择相应的文件夹！", "消息提示：");
            }
           
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BeginEdit();
           
        }    

        private void 闭合CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.Collapse();
        }

        private void 展开EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.ExpandAll();
        }


      
       /// <summary>
       /// rightClickOnOutPutWindow
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void 清除CToolStripOutPut_Click(object sender, EventArgs e)
        {
            richOutPut.Clear();
        }

        private void 查找FToolStripOutPut_Click(object sender, EventArgs e)
        {

        }

        private void 红RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richOutPut.SelectionBackColor = Color.Red;
        }

        private void 粉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richOutPut.SelectionBackColor = Color.Pink;
        }

        private void 黄3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richOutPut.SelectionBackColor = Color.Yellow;
        }

        private void 绿4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richOutPut.SelectionBackColor = Color.SpringGreen;
        }

        private void 默认DToolStripOutPut_Click(object sender, EventArgs e)
        {
            richOutPut.SelectionBackColor = Color.Black;
        }

        private void 自动标记IToolStripOutPut_Click(object sender, EventArgs e)
        {

        }

        private void 自动滚屏RToolStripOutPut_Click(object sender, EventArgs e)
        {

        }

        private void 退出EToolStripOutPut_Click(object sender, EventArgs e)
        {
            rightClickOnOutPutWindow.Close();
        }


        /// <summary>
        /// 快捷键栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.执行工程ToolStripMenuItem_Click(sender, e);
            }
        }

        ///<summary>
        /// 运行cmd命令
        /// 不显示命令窗口
        /// </summary>
        /// <param name="cmdExe">指定应用程序的完整路径</param>
        /// <param name="cmdStr">执行命令行参数</param>
        private void runCmd(string cmdExe, string cmdStr)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WorkingDirectory = selectProjectFolder.SelectedPath;
                p.Start();

                string str = string.Format(@" {0} ""{1}"" {2}", cmdExe, cmdStr, "&exit");
                p.StandardInput.WriteLine(str);

                p.StandardInput.AutoFlush = true;
                string outputMsg = p.StandardOutput.ReadToEnd();
                string errorMsg = p.StandardError.ReadToEnd();

                p.WaitForExit();
                p.Close();
                this.richOutPut.AppendText(outputMsg + errorMsg);
            }
            catch
            {

            }
        }

        /// <summary>
        /// 复制执行文件
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="str"></param>
        private void copyFileToWorkspace(string dir, string str)
        {
            try
            {
                File.Copy(dir, Path.Combine(str, Path.GetFileName(dir)), true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }
        }

        /// <summary>
        /// 编辑器自动保存功能实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileStream aFile = new FileStream(selectTreeNodeFullPath().ToString(), FileMode.OpenOrCreate);
                RichTextBox richTextBox = (RichTextBox)sender;
                RichTextBoxStreamType streamType = new RichTextBoxStreamType();
                string file_ext = selectTreeNodeFullPath().Substring(selectTreeNodeFullPath().LastIndexOf('.') + 1);
                switch (file_ext)
                {
                    case "txt":
                        streamType = RichTextBoxStreamType.PlainText; break;
                    case "py":
                        streamType = RichTextBoxStreamType.PlainText; break;
                    case "ts":
                        streamType = RichTextBoxStreamType.PlainText; break;
                    case "tc":
                        streamType = RichTextBoxStreamType.PlainText; break;
                    case "xml":
                        streamType = RichTextBoxStreamType.PlainText; break;
                    default:
                        streamType = RichTextBoxStreamType.PlainText; break;
                }
                aFile.Dispose();
                richTextBox.SaveFile(selectTreeNodeFullPath(), streamType);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }

        }


        /// <summary>
        /// 获取文件树节点的路径
        /// </summary>
        /// <returns></returns>
        private string selectTreeNodeFullPath()
        {
            string root_path_without_root_name = null;
            string root_name = tree_Solution.TopNode.Text;
            string root_path = selectProjectFolder.SelectedPath;
            string selected_node_path = tree_Solution.SelectedNode.FullPath;
            string node_name = tree_Solution.SelectedNode.Text;
            root_path_without_root_name = Regex.Match(root_path, @"[\S\s]*\\").Value;
            string full_path = Path.GetFullPath(root_path_without_root_name + "\\" + selected_node_path);
            return full_path;
        }

        /// <summary>
        /// 定位对应文件夹下的文件
        /// </summary>
        /// <param name="fileFullName"></param>
        private void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }

        /// <summary>
        /// 树节点重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeNode_NameChanged(string newNodePath)
        {
            try
            {
                if (selectTreeNodeFullPath() != newNodePath)
                {
                    FileInfo fileInfo = new FileInfo(selectTreeNodeFullPath());
                    fileInfo.MoveTo(newNodePath);
                }               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }
        }

        /// <summary>
        /// 刷新树方法
        /// </summary>
        private void refreshTreeViewData()
        {
            tree_Solution.Nodes.Clear();
            getTreeViewData(openProjectPath);
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="tipMsg"></param>
        /// <param name="control"></param>
        private void toolTipsSetToolTip(string tipMsg, Control control)
        {
            toolTips.Dispose();
            toolTips.UseFading = true;
            toolTips.UseAnimation = true;
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "提示：";
            toolTips.SetToolTip(control, tipMsg);
            toolTips.Active = true;
            toolTips.AutoPopDelay = 5000;
            toolTips.InitialDelay = 1000;
            toolTips.ReshowDelay = 500;
            toolTips.ShowAlways = true;
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="tipMsg"></param>
        /// <param name="control"></param>
        private void toolTipsShow(string tipMsg, Control control)
        {
            toolTips.Dispose();
            toolTips.UseFading = true;
            toolTips.UseAnimation = true;
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "提示：";
            toolTips.Show(tipMsg, control);
            toolTips.Active = true;
            toolTips.AutoPopDelay = 5000;
            toolTips.InitialDelay = 1000;
            toolTips.ReshowDelay = 500;
            toolTips.ShowAlways = true;
        }

        /// <summary>
        /// 选中树节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((tree_Solution.SelectedNode == null))
            {
                删除ToolStripMenuItem.Visible = false;
                标识ToolStripMenuItem.Visible = false;
                打开文件路径ToolStripMenuItem.Visible = false;
                执行工程ToolStripMenuItem.Visible = false;
                重命名ToolStripMenuItem.Visible = false;
                刷新ToolStripMenuItem.Visible = false;
                新建文件夹PToolStripMenuItem.Visible = false;
                新建文件ToolStripMenuItem.Visible = false;
                闭合CToolStripMenuItem.Visible = false;
                展开EToolStripMenuItem.Visible = false;
            }
            else
            {
                删除ToolStripMenuItem.Visible = true;
                标识ToolStripMenuItem.Visible = true;
                打开文件路径ToolStripMenuItem.Visible = true;
                执行工程ToolStripMenuItem.Visible = true;
                重命名ToolStripMenuItem.Visible = true;
                刷新ToolStripMenuItem.Visible = true;
                新建文件夹PToolStripMenuItem.Visible = true;
                新建文件ToolStripMenuItem.Visible = true;
                闭合CToolStripMenuItem.Visible = true;
                展开EToolStripMenuItem.Visible = true;

            }
        }

        /// <summary>
        /// 编辑器颜色高亮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_HightLight(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            richTextBox.Select(0, 1);
            richTextBox.SelectionColor = Color.Blue;
        }

        /// <summary>
        /// 写入待执行文件__runner.py
        /// </summary>
        /// <param name="folder"></param>
        private void writeRunSupportFile(string folder)
        {
            if (Directory.Exists(folder))
            {
                if (!File.Exists(folder + "__runner.py"))
                {
                    File.Delete(folder + "__runner.py");
                }
                FileStream fs = new FileStream(folder + "\\__runner.py", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("#--*--uft8-*-");
                sw.WriteLine("import os");
                sw.WriteLine("from ssas.logic import RunTestSuite");
                sw.WriteLine("if  __name__ == '__main__':");
                sw.WriteLine("    start_dir = os.path.dirname(__file__)");
                sw.WriteLine("    RunTestSuite().run(start_dir = start_dir)");
                sw.Close();
                richOutPut.AppendText("The execute binary files have beed copied successfully...");

            }
            else
            {
                MessageBox.Show("未找到__runner.py所对应的文件夹！", "消息提示：");
            }


        }

        /// <summary>
        /// 树形节点双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            clickTreeNodeToLoadFile();
        }

        /// <summary>
        /// 创建树形节点并加载树形文件目录
        /// </summary>
        private void clickTreeNodeToLoadFile()
        {
            if (File.Exists(selectTreeNodeFullPath()))
            {
                try
                {
                    RichTextBox richTextBox = new RichTextBox();
                    TabPage file_page = new TabPage();
                    tabCodeEditor.Controls.Add(file_page);
                    file_page.Name = tree_Solution.SelectedNode.Text;
                    file_page.Text = tree_Solution.SelectedNode.Text;
                    file_page.Controls.Add(richTextBox);
                    tabCodeEditor.SelectedTab = file_page;
                    richTextBox.Dock = DockStyle.Fill;
                    FileStream aFile = new FileStream(selectTreeNodeFullPath().ToString(), FileMode.OpenOrCreate);
                    RichTextBoxStreamType streamType = new RichTextBoxStreamType();
                    string file_ext = selectTreeNodeFullPath().Substring(selectTreeNodeFullPath().LastIndexOf('.') + 1);
                    switch (file_ext)
                    {
                        case "txt":
                            streamType = RichTextBoxStreamType.PlainText; break;
                        case "py":
                            streamType = RichTextBoxStreamType.PlainText; break;
                        case "ts":
                            streamType = RichTextBoxStreamType.PlainText; break;
                        case "tc":
                            streamType = RichTextBoxStreamType.PlainText; break;
                        case "xml":
                            streamType = RichTextBoxStreamType.PlainText; break;
                        default:
                            streamType = RichTextBoxStreamType.PlainText; break;
                    }
                    richTextBox.LoadFile(aFile, streamType);
                    aFile.Dispose();
                    richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString(), "异常消息提示：");
                }

            }

        }

        /// <summary>
        /// 关闭动态创建的编辑窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabCodeEditor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tabCodeEditor.SelectedTab.Dispose();
        }

        /// <summary>
        /// 更改树节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string root_path = selectProjectFolder.SelectedPath;
            string selected_node_path = tree_Solution.SelectedNode.FullPath;
            string root_path_without_root_name = Regex.Match(root_path, @"[\S\s]*\\").Value;
            string selected_node_path_without_node_name = Regex.Match(selected_node_path, @"[\S\s]*\\").Value;
            string full_path = Path.GetFullPath(root_path_without_root_name + "\\" + selected_node_path_without_node_name + "\\" + e.Label);
            if (e.Label!=null)
            {
                treeNode_NameChanged(full_path);
            }          
        }

        /// <summary>
        /// 获取树形目录
        /// </summary>
        /// <param name="path"></param>
        public void getTreeViewData(string path)
        {
            TreeNode root = new TreeNode();
            root.Text = "我的工程";
            getFiles(path, root);
            tree_Solution.Nodes.Add(root);

        }

        /// <summary>
        /// 从树形目录中读取文件，对应生成树形节点
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="node"></param>
        private void getFiles(string filePath, TreeNode node)
        {
            DirectoryInfo folder = new DirectoryInfo(filePath);
            node.Text = folder.Name;
            node.Tag = folder.FullName;
            FileInfo[] chldFiles = folder.GetFiles("*.*");
            foreach (FileInfo chlFile in chldFiles)
            {
                if (!chlFile.Name.StartsWith(".") && chlFile.Name != "workspace" && !chlFile.Name.StartsWith("__"))
                {
                    TreeNode chldNode = new TreeNode();
                    chldNode.Text = chlFile.Name;
                    chldNode.Tag = chlFile.FullName;
                    node.Nodes.Add(chldNode);
                }
            }

            DirectoryInfo[] chldFolders = folder.GetDirectories();
            foreach (DirectoryInfo chldFolder in chldFolders)
            {
                if (!chldFolder.Name.StartsWith(".") && chldFolder.Name != "workspace" && !chldFolder.Name.StartsWith("__"))
                {
                    TreeNode chldNode = new TreeNode();
                    chldNode.Text = folder.Name;
                    chldNode.Tag = folder.FullName;
                    node.Nodes.Add(chldNode);
                    getFiles(chldFolder.FullName, chldNode);
                }
            }

        }

        private  void delectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }
        }
    }
}
