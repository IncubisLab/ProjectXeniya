using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwilioWinForms
{
    public partial class ButtonPhoto : UserControl
    {
        public ButtonPhoto()
        {
            InitializeComponent();
        }

        private void ClickControl()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            XeniyaControl.close_sms();
            XeniyaControl.photo_show();
        }

        private void ButtonPhoto_Load(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void labelImage_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void ButtonPhoto_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
