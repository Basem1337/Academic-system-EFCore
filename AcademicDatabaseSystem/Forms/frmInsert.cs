namespace WinFormsApp
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
            lblRowsMsg.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

    }
}
