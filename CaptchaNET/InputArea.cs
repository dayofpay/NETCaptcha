using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaNET
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void InputArea_Load(object sender, EventArgs e)
        {
            Api.generateCaptcha();
            generatedCaptcha.Text = Api.getCaptcha.ToString();
        }

        private void checkCaptcha_Click(object sender, EventArgs e)
        {
            if(captchaBox.Text == Api.getCaptcha.ToString())
            {
                MessageBox.Show("Success..","CaptchaNET | dayofpay");
                ProtectedArea @protected = new ProtectedArea();
                this.Hide();
                @protected.ShowDialog();
            }
            else
            {
                Api.generateCaptcha();
                generatedCaptcha.Text = Api.getCaptcha.ToString();

                MessageBox.Show("Wrong Captcha ..", "CaptchaNET | dayofpay");
            }
        }
    }
}
