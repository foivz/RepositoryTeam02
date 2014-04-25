namespace Skladiste_ETI
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Location = new System.Drawing.Point(54, 134);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Size = new System.Drawing.Size(132, 131);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(54, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(54, 91);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(120, 20);
            this.txtPass.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
    }
}

