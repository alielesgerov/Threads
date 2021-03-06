using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Threads;

public partial class Form1 : Form
{
    private FileStream _fsOut;
    private FileStream _fsIn;
    private Thread _t;

    public Form1()
    {
        InitializeComponent();
    }

    #region ProgressCalc

    public void ProgressPosition(int precentage)
    {
        if (progressBar1.InvokeRequired)
        {
            progressBar1.BeginInvoke(new Action(() => progressBar1.Value = precentage));
            LabelProgress.BeginInvoke(new Action(() => LabelProgress.Text = precentage.ToString()+@"%"));
        }
        else
        {
            progressBar1.Value=precentage;
            LabelProgress.Text = precentage.ToString()+@"%";
        }

    }

    #endregion

    private void CloseFileAndFolder()
    {
        _fsIn.Close();
        _fsOut.Close();
    }

    private void CopyFile ()
    {
        try
        {
            _fsOut = new FileStream(TxtBoxTo.Text, FileMode.Create);
            _fsIn = new FileStream(TxtBoxFrom.Text, FileMode.Open);
            var buffer = new byte[1048576];//1MB
            int readbyte;
            while ((readbyte=_fsIn.Read(buffer, 0, buffer.Length)) > 0)
            {
                _fsOut.Write(buffer, 0, readbyte);
                Thread.Sleep(1000);
                ProgressPosition((int)(_fsIn.Position*100/_fsIn.Length));

            }
            CloseFileAndFolder();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void BtnFile1_Click(object sender, EventArgs e)
    {
       var fd = new OpenFileDialog();
        if(fd.ShowDialog() == DialogResult.OK)
        {
            TxtBoxFrom.Text = fd.FileName;
        }
    }

    private void BtnFile2_Click(object sender, EventArgs e)
    {
        var fbd = new FolderBrowserDialog();
        if(fbd.ShowDialog() == DialogResult.OK)
        {
            TxtBoxTo.Text =Path.Combine(fbd.SelectedPath, Path.GetFileName(TxtBoxFrom.Text));
        }
    }

    private void BtnCopy_Click(object sender, EventArgs e)
    {

        try
        {
            _t = new Thread(CopyFile);
            _t.IsBackground = true;
            _t.Start();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //CopyFile();
    }

    private void BtnAbort_Click(object sender, EventArgs e)
    {
        try
        {
            _t.Abort();
            ProgressPosition(0);
            CloseFileAndFolder();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [Obsolete]
    private void BtnSuspend_Click(object sender, EventArgs e)
    {
        try
        {
            _t.Suspend();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [Obsolete]
    private void BtnResume_Click(object sender, EventArgs e)
    {
        try
        {
            _t.Resume();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

