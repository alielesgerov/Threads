﻿using System;
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
        //BackgroundWorker worker = new BackgroundWorker();
        Thread t;
    
        public Form1()
        {
            InitializeComponent();
            //worker.WorkerSupportsCancellation=true;
            //worker.WorkerReportsProgress=true;

            //worker.ProgressChanged +=Worker_ProgressChanged;
            //worker.DoWork += Worker_DoWork;
        }

        #region ProgressCalc

        public void ProgressPosition(int precentage)
        {
            progressBar1.Value=precentage;
            LabelProgress.Text = precentage.ToString()+"%";

        }

        #endregion

        void CopyFile ()
        {
             FileStream fsOut = new FileStream(TxtBoxTo.Text, FileMode.Create);// to Task Folder
            FileStream fsIn = new FileStream(TxtBoxFrom.Text, FileMode.Open);
            byte [] buffer = new byte[1048576];//1MB
            int readbyte/* = fsIn.Read(buffer, 0, buffer.Length)*/;

            while((readbyte=fsIn.Read(buffer, 0, buffer.Length)) > 0)
            {
                Thread.Sleep(100);
                fsOut.Write(buffer, 0, readbyte);
                ProgressPosition((int)(fsIn.Position*100/ fsIn.Length));
                //worker.ReportProgress((int)(fsIn.Position*100/ fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();
        }


        //private void Worker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    CopyFile();
        //}

        //private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value=e.ProgressPercentage;
        //    LabelProgress.Text = e.ProgressPercentage.ToString()+"%" ;
        //}

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
            //worker.RunWorkerAsync();
            CopyFile();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            t.Abort();
            //worker.ReportProgress(0);
        }
    }
}
