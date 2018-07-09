using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SentimentAnalysis.DAL;

namespace SentimentAnalysis.UserControls
{
    public partial class LoginControl1 : UserControl
    {
        public LoginControl1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //implement login to sysytem
            using (var db = new SentimentContext())
            {

                var user = db.Employees.FirstOrDefault(x => x.Email == txtUsername.Text && x.Password == txtPassword.Text);

                if (user != null)
                {
                    MessageBox.Show(@"yes");
                    bunifuTransition1.HideSync(transparentPanel1);

                }
                else
                {
                    MessageBox.Show(@"Please sign in with correct details");
                }
            }
        }
    }
}
