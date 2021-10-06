namespace CaptchaNET
{
    partial class v
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
            this.components = new System.ComponentModel.Container();
            this.windowCore = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.captchaBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.generatedCaptcha = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkCaptcha = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // windowCore
            // 
            this.windowCore.AnimateWindow = true;
            this.windowCore.ContainerControl = this;
            // 
            // captchaBox
            // 
            this.captchaBox.BorderRadius = 15;
            this.captchaBox.BorderThickness = 2;
            this.captchaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captchaBox.DefaultText = "";
            this.captchaBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.captchaBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.captchaBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captchaBox.DisabledState.Parent = this.captchaBox;
            this.captchaBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captchaBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captchaBox.FocusedState.Parent = this.captchaBox;
            this.captchaBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.captchaBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captchaBox.HoverState.Parent = this.captchaBox;
            this.captchaBox.Location = new System.Drawing.Point(148, 99);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.PasswordChar = '\0';
            this.captchaBox.PlaceholderText = "";
            this.captchaBox.SelectedText = "";
            this.captchaBox.ShadowDecoration.Parent = this.captchaBox;
            this.captchaBox.Size = new System.Drawing.Size(91, 36);
            this.captchaBox.TabIndex = 0;
            // 
            // generatedCaptcha
            // 
            this.generatedCaptcha.BorderRadius = 15;
            this.generatedCaptcha.BorderThickness = 2;
            this.generatedCaptcha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.generatedCaptcha.DefaultText = "";
            this.generatedCaptcha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.generatedCaptcha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.generatedCaptcha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.generatedCaptcha.DisabledState.Parent = this.generatedCaptcha;
            this.generatedCaptcha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.generatedCaptcha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.generatedCaptcha.FocusedState.Parent = this.generatedCaptcha;
            this.generatedCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generatedCaptcha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.generatedCaptcha.HoverState.Parent = this.generatedCaptcha;
            this.generatedCaptcha.Location = new System.Drawing.Point(185, 31);
            this.generatedCaptcha.Name = "generatedCaptcha";
            this.generatedCaptcha.PasswordChar = '\0';
            this.generatedCaptcha.PlaceholderText = "";
            this.generatedCaptcha.ReadOnly = true;
            this.generatedCaptcha.SelectedText = "";
            this.generatedCaptcha.ShadowDecoration.Parent = this.generatedCaptcha;
            this.generatedCaptcha.Size = new System.Drawing.Size(92, 36);
            this.generatedCaptcha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Captcha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Captcha:";
            // 
            // checkCaptcha
            // 
            this.checkCaptcha.CheckedState.Parent = this.checkCaptcha;
            this.checkCaptcha.CustomImages.Parent = this.checkCaptcha;
            this.checkCaptcha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkCaptcha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkCaptcha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkCaptcha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkCaptcha.DisabledState.Parent = this.checkCaptcha;
            this.checkCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkCaptcha.ForeColor = System.Drawing.Color.White;
            this.checkCaptcha.HoverState.Parent = this.checkCaptcha;
            this.checkCaptcha.Location = new System.Drawing.Point(97, 159);
            this.checkCaptcha.Name = "checkCaptcha";
            this.checkCaptcha.ShadowDecoration.Parent = this.checkCaptcha;
            this.checkCaptcha.Size = new System.Drawing.Size(180, 45);
            this.checkCaptcha.TabIndex = 4;
            this.checkCaptcha.Text = "CONTINUE";
            this.checkCaptcha.Click += new System.EventHandler(this.checkCaptcha_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(469, 239);
            this.Controls.Add(this.checkCaptcha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatedCaptcha);
            this.Controls.Add(this.captchaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InputArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm windowCore;
        private Guna.UI2.WinForms.Guna2TextBox captchaBox;
        private Guna.UI2.WinForms.Guna2Button checkCaptcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox generatedCaptcha;
    }
}

