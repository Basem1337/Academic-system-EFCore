namespace WinFormsApp
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            //comboStd.DataSource = ;
            //comboStd.DisplayMember = "St_Fname";
            //comboStd.ValueMember = "St_Id";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {comboStd.Text} from the Database?", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }
        }
    }
}
