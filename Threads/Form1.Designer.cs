namespace Threads
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxFrom = new System.Windows.Forms.TextBox();
            this.TxtBoxTo = new System.Windows.Forms.TextBox();
            this.BtnFile1 = new System.Windows.Forms.Button();
            this.BtnFile2 = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.BtnSuspend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // TxtBoxFrom
            // 
            this.TxtBoxFrom.Location = new System.Drawing.Point(50, 13);
            this.TxtBoxFrom.Name = "TxtBoxFrom";
            this.TxtBoxFrom.Size = new System.Drawing.Size(385, 20);
            this.TxtBoxFrom.TabIndex = 2;
            // 
            // TxtBoxTo
            // 
            this.TxtBoxTo.Location = new System.Drawing.Point(50, 48);
            this.TxtBoxTo.Name = "TxtBoxTo";
            this.TxtBoxTo.Size = new System.Drawing.Size(385, 20);
            this.TxtBoxTo.TabIndex = 3;
            // 
            // BtnFile1
            // 
            this.BtnFile1.Location = new System.Drawing.Point(465, 9);
            this.BtnFile1.Name = "BtnFile1";
            this.BtnFile1.Size = new System.Drawing.Size(75, 23);
            this.BtnFile1.TabIndex = 4;
            this.BtnFile1.Text = "File";
            this.BtnFile1.UseVisualStyleBackColor = true;
            this.BtnFile1.Click += new System.EventHandler(this.BtnFile1_Click);
            // 
            // BtnFile2
            // 
            this.BtnFile2.Location = new System.Drawing.Point(465, 46);
            this.BtnFile2.Name = "BtnFile2";
            this.BtnFile2.Size = new System.Drawing.Size(75, 23);
            this.BtnFile2.TabIndex = 5;
            this.BtnFile2.Text = "File";
            this.BtnFile2.UseVisualStyleBackColor = true;
            this.BtnFile2.Click += new System.EventHandler(this.BtnFile2_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(465, 87);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 23);
            this.BtnCopy.TabIndex = 6;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnAbort
            // 
            this.BtnAbort.Location = new System.Drawing.Point(360, 87);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(75, 23);
            this.BtnAbort.TabIndex = 7;
            this.BtnAbort.Text = "Abort";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // BtnSuspend
            // 
            this.BtnSuspend.Location = new System.Drawing.Point(258, 87);
            this.BtnSuspend.Name = "BtnSuspend";
            this.BtnSuspend.Size = new System.Drawing.Size(75, 23);
            this.BtnSuspend.TabIndex = 8;
            this.BtnSuspend.Text = "Suspend";
            this.BtnSuspend.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 87);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // LabelProgress
            // 
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Location = new System.Drawing.Point(13, 87);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(21, 13);
            this.LabelProgress.TabIndex = 10;
            this.LabelProgress.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 122);
            this.Controls.Add(this.LabelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnSuspend);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnFile2);
            this.Controls.Add(this.BtnFile1);
            this.Controls.Add(this.TxtBoxTo);
            this.Controls.Add(this.TxtBoxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(572, 161);
            this.MinimumSize = new System.Drawing.Size(572, 161);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxFrom;
        private System.Windows.Forms.TextBox TxtBoxTo;
        private System.Windows.Forms.Button BtnFile1;
        private System.Windows.Forms.Button BtnFile2;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnSuspend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LabelProgress;
    }
}

