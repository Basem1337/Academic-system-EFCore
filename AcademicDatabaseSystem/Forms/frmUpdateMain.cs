using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace AcademicDatabaseSystem.Forms
{
    public partial class frmUpdateMain : Form
    {
        public frmUpdateMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void btnStdUpdate_Click(object sender, EventArgs e)
        {
            frmStdUpdate updateFrm = new frmStdUpdate();
            updateFrm.Show();
            this.Close();
        }

        private void btnInstUpdate_Click(object sender, EventArgs e)
        {
            frmInstUpdate updateFrm = new frmInstUpdate();
            updateFrm.Show();
            this.Close();
        }

        private void btnDeptUpdate_Click(object sender, EventArgs e)
        {
            frmDeptUpdate updateFrm = new frmDeptUpdate();
            updateFrm.Show();
            this.Close();
        }

        private void btnCrsUpdate_Click(object sender, EventArgs e)
        {
            frmCrsUpdate updateFrm = new frmCrsUpdate();
            updateFrm.Show();
            this.Close();
        }

        private void btnCSUpdate_Click(object sender, EventArgs e)
        {
            frmCrsSessionUpdate updateFrm = new frmCrsSessionUpdate();
            updateFrm.Show();
            this.Close();
        }

        private void btnCSAUpdate_Click(object sender, EventArgs e)
        {
            frmCrsSessionAttUpdate updateFrm = new frmCrsSessionAttUpdate();
            updateFrm.Show();
            this.Close();
        }
    }
}
