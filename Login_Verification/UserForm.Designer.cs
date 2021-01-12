
namespace Login_Verification
{
    partial class UserForm
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
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.button_logout = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(27, 27);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(146, 29);
            this.siticoneLabel1.TabIndex = 0;
            this.siticoneLabel1.Text = "R E G I S T E R";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.siticoneLabel1);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(-1, -4);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(640, 77);
            this.siticoneGradientPanel1.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(23, 120);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Role";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(133, 118);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 16);
            this.label_id.TabIndex = 24;
            this.label_id.Text = "000";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.Location = new System.Drawing.Point(133, 167);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(29, 16);
            this.label_firstname.TabIndex = 25;
            this.label_firstname.Text = "000";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.Location = new System.Drawing.Point(133, 214);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(29, 16);
            this.label_lastname.TabIndex = 26;
            this.label_lastname.Text = "000";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(133, 269);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(29, 16);
            this.label_username.TabIndex = 27;
            this.label_username.Text = "000";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(391, 120);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(29, 16);
            this.label_role.TabIndex = 28;
            this.label_role.Text = "000";
            // 
            // button_logout
            // 
            this.button_logout.CheckedState.Parent = this.button_logout;
            this.button_logout.CustomImages.Parent = this.button_logout;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.HoveredState.Parent = this.button_logout;
            this.button_logout.Location = new System.Drawing.Point(436, 325);
            this.button_logout.Name = "button_logout";
            this.button_logout.ShadowDecoration.Parent = this.button_logout;
            this.button_logout.Size = new System.Drawing.Size(115, 39);
            this.button_logout.TabIndex = 29;
            this.button_logout.Text = "Log Out";
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_role;
        private Siticone.UI.WinForms.SiticoneGradientButton button_logout;
    }
}