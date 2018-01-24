using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;


namespace TwilioWinForms
{
    public partial class ProjectXeniya : Form
    {
        private ChromiumWebBrowser chrome = new ChromiumWebBrowser("https://xeniya.mybluemix.net");
        private MenuHandler mhandler; 
        TwilioSmS twilio_sms = new TwilioSmS();

        public ProjectXeniya()
        {
            InitializeComponent();
    
            XeniyaControl.chat_show = new XeniyaControl.ChatShowDisplay(ChatShow);
            XeniyaControl.photo_show = new XeniyaControl.PhotoShowDisplay(PhotoShow);
            XeniyaControl.sms_show = new XeniyaControl.SMS_ShowDisplay(SMS_Show);

            XeniyaControl.close_chat = new XeniyaControl.CloseChatDisplay(CloseChat);
            XeniyaControl.close_sms = new XeniyaControl.CloseChatDisplay(SMS_Close);
        }

        private void ProjectXeniya_Load(object sender, EventArgs e)
        {
            ButtonChat button_chat = new ButtonChat();
            button_chat.Show();
            button_chat.Location = new Point(2, 5);
            panelControl.Controls.Add(button_chat);

            ButtonPhoto button_photo = new ButtonPhoto();
            button_photo.Show();
            button_photo.Location = new Point(2, 72);
            panelControl.Controls.Add(button_photo);

            ButtonSms button_sms = new ButtonSms();
            button_sms.Show();
            button_sms.Location = new Point(2,129);
            panelControl.Controls.Add(button_sms);
        }

        public void ChatShow()
        {
            mhandler = new MenuHandler(chrome);
            chrome.MenuHandler = mhandler;
            chrome.Load("https://nodeexample.eu-gb.mybluemix.net/bot1");
            chrome.Dock = DockStyle.Fill;
            panelShow.Controls.Add(chrome);
        }

        public void CloseChat()
        {
            panelShow.Controls.Remove(chrome);
        }

        public void PhotoShow()
        {
            mhandler = new MenuHandler(chrome);
            chrome.MenuHandler = mhandler;
            chrome.Load("https://hostpohto123.eu-gb.mybluemix.net/");
            chrome.Dock = DockStyle.Fill;
            panelShow.Controls.Add(chrome);
        }

        public void SMS_Show()
        {
            twilio_sms.Show();
            panelShow.Controls.Add(twilio_sms);
        }

        public void SMS_Close()
        {
            panelShow.Controls.Remove(twilio_sms);
        }
    }
}
