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
    public partial class ButtonChat : UserControl
    {
        public ButtonChat()
        {
            InitializeComponent();
        }
        private void ClickControl()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            XeniyaControl.close_sms();
            XeniyaControl.chat_show();
           
        }
        private void ButtonChat_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void labelCha_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void pictureChat_Click(object sender, EventArgs e)
        {
            ClickControl();
        }

        private void ButtonChat_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
