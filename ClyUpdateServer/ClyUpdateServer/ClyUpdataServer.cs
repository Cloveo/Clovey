using CCWin;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace ClyUpdateServer
{
    public partial class ClyUpdateServer : CCSkinMain
    {

        private DataTable dtFile;
        private string SavePath = "";
        public ClyUpdateServer()
        {
            InitializeComponent();
            SetDateTable();
        }
        /// <summary>
        /// 选择文件
        /// </summary>
        private void ShowSelectFile()
        {
            ////弹窗选择文件
            //OpenFileDialog file = new OpenFileDialog();
            //file.InitialDirectory = currentPath;            
            //file.Multiselect = true;
            fb_SeletFile = new FolderBrowserDialog();
            DialogResult reslut = fb_SeletFile.ShowDialog();
            if (reslut == DialogResult.OK)
            {
                this.SavePath = fb_SeletFile.SelectedPath + "\\";
                this.dtFile.Clear();
                GetFiles(fb_SeletFile.SelectedPath, fb_SeletFile.SelectedPath);
            }
            DataView dv = this.dtFile.DefaultView;
            dv.Sort = "SIZE";
            this.dtFile = dv.ToTable();
            dgv_Files.DataSource = this.dtFile;
            if (File.Exists(this.SavePath + "ClyFile.xml"))
            {
                var xmlPath = this.SavePath + "ClyFile.xml";
                //获取版本信息
                var vernode = XMLHelper.GetXmlNodeValueByXpath(xmlPath, "/Config/Version");
                this.txtClyVersion.Text = vernode;
                //this.lblk
                //获取更新描述
                var releaseNote = XMLHelper.GetXmlNodeValueByXpath(xmlPath, "/Config/Remark");
                this.txtDescription.Text = releaseNote;
            }
        }

        private void GetFiles(string FatherPath, string delpath)
        {
            foreach (string path in Directory.GetDirectories(FatherPath))
            {
                GetFiles(path, delpath);
            }
            SelectFiles(FatherPath, delpath);
        }

        private void SelectFiles(string path, string delpath)
        {
            foreach (string pathF in Directory.GetFiles(path))
            {
                FileInfo i = new FileInfo(pathF);
                if (!i.Exists || i.Name == "ClyFile.xml")
                    continue;
                DataRow DR = this.dtFile.NewRow();
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(pathF);
                DR[0] = i.FullName.Substring(delpath.Length + 1, i.FullName.Length - delpath.Length - 1);
                DR[1] = i.LastWriteTime.ToString("yyyyMMddhhmmss");
                DR[2] = i.Length;
                this.dtFile.Rows.Add(DR);
            }
        }

        private void SetDateTable()
        {
            dgv_Files.AutoGenerateColumns = false;
            dtFile = new DataTable();
            dtFile.Columns.Add("Name");
            dtFile.Columns.Add("Version");
            dtFile.Columns.Add(new DataColumn("SIZE", typeof(int)));
        }

        public void SetValue(string Name, string Ver, string Size)
        {
            DataRow dr = dtFile.NewRow();
            dr[0] = Name;
            dr[1] = Ver;
            dr[2] = Size;
            dtFile.Rows.Add(dr);
        }

        private void ClyUpdateServer_Load(object sender, EventArgs e)
        {
            try
            {
                var xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "ClyFile.xml";
                //获取版本信息
                var vernode = XMLHelper.GetXmlNodeValueByXpath(xmlPath, "/Config/Version");
                this.txtClyVersion.Text = vernode;
                //this.lblk
                //获取更新描述
                var releaseNote = XMLHelper.GetXmlNodeValueByXpath(xmlPath, "/Config/Remark");
                this.txtDescription.Text = releaseNote;
            }
            catch
            {

            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (this.dgv_Files.RowCount == 0)
            {
                MessageBox.Show("请选择文件后再生产更新列表！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtClyVersion.Text.Trim() == "")
            {
                MessageBox.Show("请输入发布版本号！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("请输入更新说明！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var xmlPath = this.SavePath + "ClyFile.xml";
            //保存设置到XML
            var xmlText = "";
            for (int i = 0; i < this.dtFile.Rows.Count; i++)
            {
                xmlText += String.Format("<File Name=\"{0}\" Version=\"{1}\" Size=\"{2}\"/>", this.dtFile.Rows[i][0], this.dtFile.Rows[i][1], this.dtFile.Rows[i][2]);
            }
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists(xmlPath))
            {
                File.Delete(xmlPath);
            }
            XmlDeclaration xmldecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement root1 = xmlDoc.DocumentElement;
            xmlDoc.InsertBefore(xmldecl, root1);
            XmlElement Node = xmlDoc.CreateElement("Config");//创建一个Config节点          
            xmlDoc.AppendChild(Node);
            xmlDoc.Save(xmlPath);
            xmlDoc.Load(xmlPath); //加载XML文档
            XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlDoc, "/Config", "Version", this.txtClyVersion.Text.Trim());
            XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlDoc, "/Config", "Remark", this.txtDescription.Text);
            XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlDoc, "/Config", "Files", xmlText);
            xmlDoc.Save(xmlPath);
            MessageBox.Show("ClyFile.xml 文件创建在更新文件列表中！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            ShowSelectFile();
        }

        private void menuDelet_Click(object sender, EventArgs e)
        {
            if (dgv_Files.RowCount == 0)
                return;
            ArrayList al = new ArrayList();
            for (int i = 0; i < dgv_Files.RowCount; i++)
            {
                if (dgv_Files.Rows[i].Cells["col_Sel"].Value != null && dgv_Files.Rows[i].Cells["col_Sel"].Value.ToString() == "True")
                {
                    al.Add(dgv_Files.Rows[i].Cells["col_FileName"].Value.ToString());
                }
            }
            DataView dv = this.dtFile.DefaultView;
            for (int i = 0; i < al.Count; i++)
            {

                dv.RowFilter = "name <>'" + al[i].ToString() + "'";
                dv = dv.ToTable().DefaultView;
            }
            this.dtFile = dv.ToTable();
            this.dgv_Files.DataSource = this.dtFile;
        }

        private void dgv_Files_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv_Files.Columns[e.ColumnIndex].Name != "col_Del")
                return;
            DataView dv = this.dtFile.DefaultView;
            dv.RowFilter = "name <>'" + dgv_Files.Rows[e.RowIndex].Cells["col_FileName"].Value.ToString() + "'";
            this.dtFile = dv.ToTable();
            this.dgv_Files.DataSource = this.dtFile;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShowSelectFile();
        }
    }
}
