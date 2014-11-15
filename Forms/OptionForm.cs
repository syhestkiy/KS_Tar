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
using KS_Tar.Classes;
using KS_Tar.OptionRepository;

namespace KS_Tar.Forms
{
    public partial class OptionForm : Form
    {
        public IOptionRepository OptionsRepository=new OptionRepository.OptionRepository();
        public Options UserOptions;
        public OptionForm()
        {
            InitializeComponent();
            UserOptions = OptionsRepository.GetOption();
            txtEmail.Text = UserOptions.EmailTo;
            txtSenderEmail.Text = UserOptions.FromEmail;
            txtSenderEmaiPass.Text = UserOptions.FromEmailPassword;
            txtEmailSubject.Text = UserOptions.EmailSubject;
            richTxtMessage.Text = UserOptions.EmailBody;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            OptionsRepository.SaveOption
            (
              txtEmail.Text,
              txtSenderEmail.Text,
              txtSenderEmaiPass.Text,
              txtEmailSubject.Text,
              richTxtMessage.Text
            );
            Close();
        }

     }
}
