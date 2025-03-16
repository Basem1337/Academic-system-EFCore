namespace WinFormsApp
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelect selectFrm = new frmSelect();
            selectFrm.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert insertFrm = new frmInsert();
            insertFrm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate updateFrm = new frmUpdate();
            updateFrm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete deleteFrm = new frmDelete();
            deleteFrm.Show();
            this.Hide();
        }
    }
}
