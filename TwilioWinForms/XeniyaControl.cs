using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioWinForms
{
    public static class XeniyaControl
    {
        public delegate void ChatShowDisplay();
        public static ChatShowDisplay chat_show;

        public delegate void CloseChatDisplay();
        public static CloseChatDisplay close_chat;

        public delegate void PhotoShowDisplay();
        public static PhotoShowDisplay photo_show;

        public delegate void SMS_ShowDisplay();
        public static SMS_ShowDisplay sms_show;

        public delegate void CloseSMS_Display();
        public static CloseChatDisplay close_sms;

    }
}
