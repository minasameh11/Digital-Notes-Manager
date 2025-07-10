namespace DigitalNotesManager
{
    public partial class LoginForm : Form
    {


        public int LoggedInUserID { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;

        }


        ////////////////////////////////////////////////////////////////////////////
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userId = DataAccess.ValidateUser(txtUsername.Text, txtPassword.Text);

            if (userId > 0)
            {
                this.LoggedInUserID = userId;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        ///***************************fake *******************************************






        ////**********************************************************************
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
