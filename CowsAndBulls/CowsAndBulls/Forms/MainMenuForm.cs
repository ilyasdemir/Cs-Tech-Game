using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Tech.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e) // Kullanıcı Modu...
        {
            var gameForm = new User();
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }

        private void btnComputer_Click(object sender, EventArgs e) // Bilgisayar modu...
        {
            var gameForm = new Computer();
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }
    }
}
