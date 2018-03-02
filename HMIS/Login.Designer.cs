namespace HMIS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.username_Textbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.password_Textbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.login_Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancel_Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(291, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(256, 317);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // username_Textbox1
            // 
            this.username_Textbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.username_Textbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username_Textbox1.BackgroundImage")));
            this.username_Textbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username_Textbox1.ForeColor = System.Drawing.Color.Snow;
            this.username_Textbox1.Icon = ((System.Drawing.Image)(resources.GetObject("username_Textbox1.Icon")));
            this.username_Textbox1.Location = new System.Drawing.Point(67, 94);
            this.username_Textbox1.Name = "username_Textbox1";
            this.username_Textbox1.Size = new System.Drawing.Size(199, 43);
            this.username_Textbox1.TabIndex = 4;
            this.username_Textbox1.text = "Username";
            // 
            // password_Textbox2
            // 
            this.password_Textbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.password_Textbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_Textbox2.BackgroundImage")));
            this.password_Textbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_Textbox2.ForeColor = System.Drawing.Color.Snow;
            this.password_Textbox2.Icon = ((System.Drawing.Image)(resources.GetObject("password_Textbox2.Icon")));
            this.password_Textbox2.Location = new System.Drawing.Point(67, 172);
            this.password_Textbox2.Name = "password_Textbox2";
            this.password_Textbox2.Size = new System.Drawing.Size(199, 43);
            this.password_Textbox2.TabIndex = 5;
            this.password_Textbox2.text = "Password";
            // 
            // login_Button1
            // 
            this.login_Button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_Button1.BorderRadius = 0;
            this.login_Button1.ButtonText = "Login";
            this.login_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_Button1.DisabledColor = System.Drawing.Color.Gray;
            this.login_Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.login_Button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("login_Button1.Iconimage")));
            this.login_Button1.Iconimage_right = null;
            this.login_Button1.Iconimage_right_Selected = null;
            this.login_Button1.Iconimage_Selected = null;
            this.login_Button1.IconMarginLeft = 0;
            this.login_Button1.IconMarginRight = 0;
            this.login_Button1.IconRightVisible = true;
            this.login_Button1.IconRightZoom = 0D;
            this.login_Button1.IconVisible = true;
            this.login_Button1.IconZoom = 90D;
            this.login_Button1.IsTab = false;
            this.login_Button1.Location = new System.Drawing.Point(173, 251);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_Button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.login_Button1.selected = false;
            this.login_Button1.Size = new System.Drawing.Size(93, 33);
            this.login_Button1.TabIndex = 6;
            this.login_Button1.Text = "Login";
            this.login_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_Button1.Textcolor = System.Drawing.Color.White;
            this.login_Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // cancel_Button1
            // 
            this.cancel_Button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancel_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cancel_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel_Button1.BorderRadius = 0;
            this.cancel_Button1.ButtonText = "Cancel";
            this.cancel_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Button1.DisabledColor = System.Drawing.Color.Gray;
            this.cancel_Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel_Button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel_Button1.Iconimage")));
            this.cancel_Button1.Iconimage_right = null;
            this.cancel_Button1.Iconimage_right_Selected = null;
            this.cancel_Button1.Iconimage_Selected = null;
            this.cancel_Button1.IconMarginLeft = 0;
            this.cancel_Button1.IconMarginRight = 0;
            this.cancel_Button1.IconRightVisible = true;
            this.cancel_Button1.IconRightZoom = 0D;
            this.cancel_Button1.IconVisible = true;
            this.cancel_Button1.IconZoom = 90D;
            this.cancel_Button1.IsTab = false;
            this.cancel_Button1.Location = new System.Drawing.Point(48, 251);
            this.cancel_Button1.Name = "cancel_Button1";
            this.cancel_Button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cancel_Button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cancel_Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel_Button1.selected = false;
            this.cancel_Button1.Size = new System.Drawing.Size(95, 33);
            this.cancel_Button1.TabIndex = 7;
            this.cancel_Button1.Text = "Cancel";
            this.cancel_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_Button1.Textcolor = System.Drawing.Color.White;
            this.cancel_Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button1.Click += new System.EventHandler(this.cancel_Button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 317);
            this.Controls.Add(this.cancel_Button1);
            this.Controls.Add(this.login_Button1);
            this.Controls.Add(this.password_Textbox2);
            this.Controls.Add(this.username_Textbox1);
            this.Controls.Add(this.bunifuImageButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuTextbox username_Textbox1;
        private Bunifu.Framework.UI.BunifuTextbox password_Textbox2;
        private Bunifu.Framework.UI.BunifuFlatButton login_Button1;
        private Bunifu.Framework.UI.BunifuFlatButton cancel_Button1;
    }
}