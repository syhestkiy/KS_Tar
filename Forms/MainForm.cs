using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using KS_Tar.Classes;
using KS_Tar.Forms;
using KS_Tar.OptionRepository;

namespace KS_Tar
{
    struct SelectedParams
    {
        public Drive Drive;
        public long MemoryLim;
        public int TimeLim;

        public SelectedParams(Drive drive, long memory, int time)
        {
            Drive = drive;
            MemoryLim = memory;
            TimeLim = time;
        }
    }
    public partial class mainForm : Form
    {
        private IOptionRepository _optionRepository = new OptionRepository.OptionRepository();
        public Options UserOptions;
        private readonly List<Drive> _drives;
        private SelectedParams _selectedParams = new SelectedParams();
        public bool IfOptionsFileExist = false;
        public mainForm()
        {
            InitializeComponent();
            UserOptions = _optionRepository.GetOption();
            _drives = MemoryChecker.GetListOfDrives();
            foreach (var d in MemoryChecker.ListOfDriveNames(_drives))
            {
                comboBoxDrives.Items.Add(d);
            }
            foreach (var limit in Options.MemoryLimitsArray)
            {
                comboBoxMemoryLimit.Items.Add(limit);
            }

            foreach (var interval in Options.TimeIntervalsArray)
            {
                comboBoxTimeInterval.Items.Add(interval);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedIndex == -1 || comboBoxMemoryLimit.SelectedIndex == -1 ||
                comboBoxTimeInterval.SelectedIndex == -1)
            {
                MessageBox.Show("Ви не задали параметри роботи", "Options not set", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (UserOptions.OptionExist)
                {
                    GetParams(ref _selectedParams);
                    ProcessStart();
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Ви не встановили налаштування", "Options not set", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker.Dispose();
            OperationDone();
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
            sP.Drive = _drives[comboBoxDrives.SelectedIndex];
            sP.TimeLim = Options.TimeIntervalsArray[comboBoxTimeInterval.SelectedIndex];
            sP.MemoryLim = Options.MemoryLimitsArray[comboBoxMemoryLimit.SelectedIndex];
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
            EmailSender.SendMail(UserOptions.EmailTo, UserOptions.FromEmail, UserOptions.FromEmailPassword, UserOptions.EmailSubject, UserOptions.EmailBody);
        }

        private void OperationDone()
        {
            comboBoxDrives.Enabled = true;
            comboBoxMemoryLimit.Enabled = true;
            comboBoxTimeInterval.Enabled = true;
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form oF = new OptionForm();
            oF.ShowDialog();
        }

        private void проToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aF = new AboutForm();
            aF.ShowDialog();

        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
        }

        private void показатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Focus();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Видійсно хочете вийти", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
