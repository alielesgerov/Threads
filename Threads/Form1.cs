using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threads
{
    public partial class Form1 : Form
    {
        FileStream fsOut;
        FileStream fsIn;
        Thread t;
    
        public Form1()
        {
            InitializeComponent();
        }

        #region ProgressCalc

        public void ProgressPosition(int precentage)
        {
            progressBar1.Value=precentage;
            LabelProgress.Text = precentage.ToString()+"%";

        }

        #endregion

        void CloseFileAndFolder()
        {
            fsIn.Close();
            fsOut.Close();
        }

        void CopyFile ()
        {
            fsOut = new FileStream(TxtBoxTo.Text, FileMode.Create);
            fsIn = new FileStream(TxtBoxFrom.Text, FileMode.Open);
            byte[] buffer = new byte[1048576];//1MB
            int readbyte;
            do
            {
                readbyte=fsIn.Read(buffer, 0, buffer.Length);
                fsOut.Write(buffer, 0, readbyte);
                Thread.Sleep(100);

            } while (readbyte > 0) ;
            CloseFileAndFolder();

        }

        private void BtnFile1_Click(object sender, EventArgs e)
        {
           OpenFileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                TxtBoxFrom.Text = fd.FileName;
            }
        }

        private void BtnFile2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                TxtBoxTo.Text =Path.Combine(fbd.SelectedPath, Path.GetFileName(TxtBoxFrom.Text));
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            
            t = new Thread(CopyFile);
            t.Start();
            //CopyFile();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            try
            {
                t.Abort();
                ProgressPosition(0);
                CloseFileAndFolder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Obsolete]
        private void BtnSuspend_Click(object sender, EventArgs e)
        {
            try
            {
                t.Suspend();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Obsolete]
        private void BtnResume_Click(object sender, EventArgs e)
        {
            try
            {
                t.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
