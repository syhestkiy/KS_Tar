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

namespace KS_Tar.Forms
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            var sr = new StreamReader("email.ini");
            txtEmail.Text = sr.ReadToEnd();
            sr=new StreamReader("message.ini");
            richTxtBoxMessage.Text = sr.ReadToEnd();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter outfile = new StreamWriter("email.ini"))
            {
                outfile.Write(txtEmail.Text);
            }
            using (StreamWriter outfile = new StreamWriter("message.ini"))
            {
                outfile.Write(richTxtBoxMessage.Text);
            }
            Close();
        }
    }
}
