namespace WinFormsApp
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
