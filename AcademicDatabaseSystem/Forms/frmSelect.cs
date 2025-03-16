namespace WinFormsApp
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            //comboStd.DataSource = ;
            //comboStd.DisplayMember = "St_Fname";
            //comboStd.ValueMember = "St_Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



    }
}
