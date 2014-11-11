using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using KS_Tar.Classes;
using KS_Tar.Forms;

namespace KS_Tar
{
    struct SelectedParams
    {
        public Drive Drive;
        public long MemoryLim;
        public int TimeLim;
        public string Email;

        public SelectedParams(Drive drive, long memory,int time,string email)
        {
            Drive = drive;
            MemoryLim = memory;
            TimeLim = time;
            Email = email;
        }
    }
    public delegate void SomeAction();
    public partial class mainForm : Form
    {
        private readonly List<Drive> _drives ;
        private SelectedParams _selectedParams = new SelectedParams();
        public bool IfOptionsFileExist = false;
        public string email = string.Empty;
        public mainForm()
        {
            InitializeComponent();

            _drives = MemoryChecker.GetListOfDrives();
            foreach (var d in MemoryChecker.ListOfDriveNames(_drives))
            {
                comboBoxDrives.Items.Add(d);
            }
            foreach (var limit in Options.MemoryLimits)
            {
                comboBoxMemoryLimit.Items.Add(limit);
            }

            foreach (var interval in Options.TimeIntervals)
            {
                comboBoxTimeInterval.Items.Add(interval);
            }
            try
            {
                var sr = new StreamReader("email.ini");
                email=sr.ReadToEnd();
                sr = new StreamReader("message.ini");
                sr.ReadToEnd();
                IfOptionsFileExist = true;
            }
            catch
            {
                using (StreamWriter outfile = new StreamWriter("email.ini"))
                {
                    outfile.Write(string.Empty);
                }
                using (StreamWriter outfile = new StreamWriter("message.ini"))
                {
                    outfile.Write(string.Empty);
                }
                IfOptionsFileExist = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetParams(ref _selectedParams);
            ProcessStart();
            backgroundWorker.RunWorkerAsync();
         }

        private void btnStop_Click(object sender, EventArgs e)
        {
            OperationDone();
            backgroundWorker.Dispose();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Operation();
        }

        private void ProcessStart()
        {
            comboBoxDrives.Enabled = false;
            comboBoxMemoryLimit.Enabled = false;
            comboBoxTimeInterval.Enabled = false;
        }

        private void GetParams(ref SelectedParams sP)
        {
            sP.Drive= _drives[comboBoxDrives.SelectedIndex];
            sP.TimeLim = Options.TimeIntervals[comboBoxTimeInterval.SelectedIndex];
            sP.MemoryLim= Options.MemoryLimits[comboBoxMemoryLimit.SelectedIndex];
            if (IfOptionsFileExist)
                sP.Email = email;
            else
                sP.Email = string.Empty;

        }

        private void Operation()
        {
            while (true)
            {
                if (_selectedParams.Drive.TotalFreeSpace < _selectedParams.MemoryLim)
                {
                    backgroundWorker.Dispose();
                    break;
                }
                
                Thread.Sleep(_selectedParams.TimeLim);
            }
            EmailSender.SendMail(_selectedParams.Email);
        }

        private void OperationDone()
        {
            comboBoxDrives.Enabled = true;
            comboBoxMemoryLimit.Enabled = true;
            comboBoxTimeInterval.Enabled = true;
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form oF=new OptionForm();
            oF.ShowDialog();
        }

        private void проToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aF=new AboutForm();
            aF.ShowDialog();
        }

    }
}
