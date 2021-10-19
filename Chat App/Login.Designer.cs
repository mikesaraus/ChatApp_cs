
namespace Chat_App
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitLabel = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.buttonTooglePassview = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Chat_App.Properties.Resources.i_chat_icon;
            this.pictureBox1.Location = new System.Drawing.Point(144, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // submitLabel
            // 
            this.submitLabel.BackColor = System.Drawing.Color.Transparent;
            this.submitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLabel.ForeColor = System.Drawing.Color.White;
            this.submitLabel.Location = new System.Drawing.Point(226, 325);
            this.submitLabel.Name = "submitLabel";
            this.submitLabel.Size = new System.Drawing.Size(145, 46);
            this.submitLabel.TabIndex = 1;
            this.submitLabel.Text = "Submit";
            this.submitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitLabel.Click += new System.EventHandler(this.submitLabel_Click);
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.White;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.Black;
            this.textUsername.Location = new System.Drawing.Point(117, 196);
            this.textUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(256, 22);
            this.textUsername.TabIndex = 3;
            this.textUsername.Text = "Username";
            this.textUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submitLogin_KeyDown_ByEnter);
            // 
            // buttonTooglePassview
            // 
            this.buttonTooglePassview.BackColor = System.Drawing.Color.White;
            this.buttonTooglePassview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTooglePassview.BackgroundImage")));
            this.buttonTooglePassview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTooglePassview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTooglePassview.FlatAppearance.BorderSize = 0;
            this.buttonTooglePassview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonTooglePassview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonTooglePassview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTooglePassview.Location = new System.Drawing.Point(333, 263);
            this.buttonTooglePassview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTooglePassview.Name = "buttonTooglePassview";
            this.buttonTooglePassview.Size = new System.Drawing.Size(38, 30);
            this.buttonTooglePassview.TabIndex = 6;
            this.buttonTooglePassview.UseVisualStyleBackColor = false;
            this.buttonTooglePassview.Click += new System.EventHandler(this.buttonTooglePassview_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.Location = new System.Drawing.Point(117, 267);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(210, 22);
            this.textPassword.TabIndex = 5;
            this.textPassword.Text = "Password";
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submitLogin_KeyDown_ByEnter);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.LightGray;
            this.closeLabel.Location = new System.Drawing.Point(213, 435);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(20, 20);
            this.closeLabel.TabIndex = 7;
            this.closeLabel.Text = "x";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_click);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(61, 136);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(321, 28);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Login to ChatApp";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(61, 334);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(127, 28);
            this.labelRegister.TabIndex = 9;
            this.labelRegister.Text = "Create an Account?";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            this.labelRegister.MouseLeave += new System.EventHandler(this.labelRegister_MouseLeave);
            this.labelRegister.MouseHover += new System.EventHandler(this.labelRegister_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 474);
            this.Controls.Add(this.submitLabel);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.buttonTooglePassview);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to ChatApp";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label submitLabel;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button buttonTooglePassview;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRegister;
    }
}