using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToolCheckSHD
{
    public partial class FrmToolCheck : Form
    {
        public FrmToolCheck()
        {
            InitializeComponent();
        }
        List<string> locFile = new List<string>();
        FolderBrowserDialog fd = new FolderBrowserDialog();
        int counter = 0;
        private void FrmToolCheck_Load(object sender, EventArgs e) { }
        private void showImage()
        {
            try
            {
                if (counter == locFile.Count())
                {
                    MessageBox.Show("Complete!!!", "", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    ImageView.Image = Image.FromFile(locFile[counter]);
                    lblValueIndex.Text = Convert.ToInt32(counter + 1) + "/" + locFile.Count.ToString();
                    this.txtEntry.Focus();
                    checkName();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void checkName()
        {
            txtNameImage.Text = Path.GetFileName(locFile[counter]).Trim();
        }
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            try
            {
                fd.ShowDialog();
                locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                txtPath.Text = fd.SelectedPath.ToString();
                if (locFile.Count() == 0)
                {
                    txtNameImage.Clear();
                    lblValueIndex.ResetText();
                    MessageBox.Show("This Folder don't have a picture", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showImage();
                    this.txtEntry.Clear();
                   
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ImageView.Image.Dispose();
                    File.Move(fd.SelectedPath + "\\" + Path.GetFileName(locFile[counter]), txtPath.Text + "\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + txtEntry.Text.Trim() + ".jpg");
                    counter += 1;
                    showImage();
                    this.txtEntry.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FrmToolCheck_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Escape:
                        DialogResult dg = MessageBox.Show("Bạn muốn thoát hệ thống.!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dg == DialogResult.OK)
                        { Application.Exit(); }
                        break;
                    case Keys.Delete:
                        ImageView.Image.Dispose();
                        File.Delete(locFile[counter]);
                        locFile.RemoveAt(counter);
                        showImage();
                        this.txtEntry.Clear();
                        checkName();
                        break;
                    case Keys.F1:
                        ImageView.Image.Dispose();
                        locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        counter += 1;
                        showImage();
                        this.txtEntry.Clear();
                        break;
                    case Keys.F2:
                        if (counter == 0)
                        {
                            return;
                        }
                        else if (counter > 0)
                        {
                            ImageView.Image.Dispose();
                            locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                            counter -= 1;
                            showImage();
                            this.txtEntry.Clear();
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}


