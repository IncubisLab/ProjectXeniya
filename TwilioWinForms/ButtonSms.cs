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
    public partial class ButtonSms : UserControl
    {
        public ButtonSms()
        {
            InitializeComponent();
        }

        private void ClickControl()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            XeniyaControl.close_chat();
            XeniyaControl.sms_show();
            
        }

        private void ButtonSms_Click(object sender, EventArgs e)
        {
            ClickControl();

        }

        private void labelsms_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void pictureSMS_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void ButtonSms_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
