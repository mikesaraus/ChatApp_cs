using FireSharp;
using FireSharp.Response;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chat_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static FirebaseClient _client = (FirebaseClient)Program._client;
        private bool Passview = false;

        private async void submitLabel_Click(object sender, EventArgs e)
        {
            // Disable Input Boxes
            textUsername.ReadOnly = true;
            textPassword.ReadOnly = true;
            submitLabel.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                string username = textUsername.Text.ToLower();
                // Perform Login Action
                FirebaseResponse response = await _client.GetAsync(Paths.Users + username);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    PersonalData myDeserializeData = response.ResultAs<PersonalData>();
                    if (myDeserializeData != null && myDeserializeData.Password != null)
                    {
                        Cmd cmd = new Cmd();
                        if (myDeserializeData.Password != null && myDeserializeData.Password == cmd.Base64_Encode(textPassword.Text))
                        {
                            myDeserializeData.Username = username;
                            Program._profile = myDeserializeData;
                            textUsername.Text = "Username";
                            textPassword.Text = "Password";
                            textUsername.Focus();
                            if (Program.MainForm.IsDisposed) Program.MainForm = new ChatApp();
                            Program.MainForm.Show();
                            Hide();
                            // MessageBox.Show(this, "Howaday, " + username + "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                        else
                    {
                        MessageBox.Show(this, "Account not found!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Error " + response.StatusCode + " has occured!", response.StatusCode + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                catch (InvalidCastException err)
            {
                MessageBox.Show(this, err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reset The Input Boxes
            textUsername.ReadOnly = false;
            textPassword.ReadOnly = false;
            submitLabel.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void closeLabel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.LightGray;
        }

        private void submitLogin_KeyDown_ByEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitLabel_Click(sender, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult confirmation = MessageBox.Show(this, "Close ChatApp?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmation == DialogResult.OK) closeLabel_click(sender, null);
            }
        }

        private void buttonTooglePassview_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == new char())
            {
                buttonTooglePassview.BackgroundImage = Properties.Resources.i_eye_show;
                textPassword.PasswordChar = "*"[0];
            }
            else
            {
                buttonTooglePassview.BackgroundImage = Properties.Resources.i_eye_hidden;
                textPassword.PasswordChar = new char();
            }
            Passview = !Passview;
        }

        private void labelRegister_MouseHover(object sender, EventArgs e)
        {
            labelRegister.ForeColor = Color.DeepSkyBlue;
        }

        private void labelRegister_MouseLeave(object sender, EventArgs e)
        {
            labelRegister.ForeColor = Color.White;
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            if (Program.RegisterForm.IsDisposed) Program.RegisterForm= new Register();
            Hide();
            Program.RegisterForm.Show();
        }
    }
}
