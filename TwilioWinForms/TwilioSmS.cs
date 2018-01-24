using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioWinForms
{
    public partial class TwilioSmS : UserControl
    {
        public TwilioSmS()
        {
            InitializeComponent();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            var accountSid = "AC5a908d2dde165d2a8557faf7447af8a5";
            // Your Auth Token from twilio.com/console
            var authToken = "82bfa4e902a2e3e98dfa771867defaa3";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(textNumber.Text),
                from: new PhoneNumber("+17749933260"),
                body: textMessage.Text);

            MessageBox.Show(message.Sid +Environment.NewLine +"Сообщение отправлено!");
        }
    }
}
