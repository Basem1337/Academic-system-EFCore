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
    public partial class frmInsertMain : Form
    {
        public frmInsertMain()
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
            frmStdInsert updateFrm = new frmStdInsert();
            updateFrm.Show();
            this.Close();
        }

        private void btnInstUpdate_Click(object sender, EventArgs e)
        {
            frmInstInsert updateFrm = new frmInstInsert();
            updateFrm.Show();
            this.Close();
        }

        private void btnDeptUpdate_Click(object sender, EventArgs e)
        {
            frmDeptInsert updateFrm = new frmDeptInsert();
            updateFrm.Show();
            this.Close();
        }

        private void btnCrsUpdate_Click(object sender, EventArgs e)
        {
            frmCrsInsert updateFrm = new frmCrsInsert();
            updateFrm.Show();
            this.Close();
        }

        private void btnCSUpdate_Click(object sender, EventArgs e)
        {
            frmCrsSessionInsert updateFrm = new frmCrsSessionInsert();
            updateFrm.Show();
            this.Close();
        }

        private void btnCSAUpdate_Click(object sender, EventArgs e)
        {
            frmCrsSessionAttInsert updateFrm = new frmCrsSessionAttInsert();
            updateFrm.Show();
            this.Close();
        }
    }
}
