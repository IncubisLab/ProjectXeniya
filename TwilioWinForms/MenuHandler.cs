using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Net;

namespace TwilioWinForms
{
    internal class MenuHandler : IContextMenuHandler
    {
        private const int ShowDevTools = 26501;
        private const int CloseDevTools = 26502;
        private const int SaveImageAs = 26503;
        private const int SaveAsPdf = 26504;
        private const int SaveLinkAs = 26505;
        private const int CopyLinkAddress = 26506;
        private const int OpenLinkInNewTab = 26507;
        private const int OpenLinkInNewTab1 = 26508;
        private const int VideoNewTab = 26509;
        private const int VideoNormalTab = 26510;
        private const int PdfShow = 26511;
        private const int SceacrchGoogle = 26512;
        private const int SeacrchYandex = 26513;
        private const int SeacrchWikipedia = 26514;
        private const int Hangout = 26515;
        private const int CopyImage = 26516;
        private const int ComfortableYouTube= 26517;
        private const int WindowYouTube = 26518;
        private const int OpenDock = 26519;
        private const int ShowConsole = 26520;
        private Object thislook = new Object(); 
      
        private ChromiumWebBrowser chrome;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private static void SendCtrlhotKey(char key)
        {
            keybd_event(0x11, 0, 0, 0);
            keybd_event((byte)key, 0, 0, 0);
            keybd_event((byte)key, 0, 0x2, 0);
            keybd_event(0x11, 0, 0x2, 0);
        }

        public MenuHandler( ChromiumWebBrowser chrome1)
        {
            
            chrome = chrome1;
        }

        void IContextMenuHandler.OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();

            if (parameters.HasImageContents && parameters.SourceUrl != "")
            {
                model.AddItem((CefMenuCommand)SaveImageAs, "Сохранить изображение как");
                model.AddItem((CefMenuCommand)CopyImage, "Копировать изображение");
            }
            
            model.AddSeparator();
            model.AddItem((CefMenuCommand)ShowDevTools, "Инструменты разработчика");
            model.AddSeparator();
        }

        bool IContextMenuHandler.OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if ((int)commandId == ShowDevTools)
            {
                browser.ShowDevTools();
            }
            if ((int)commandId == CloseDevTools)
            {
                browser.CloseDevTools();
            }
            if ((int)commandId == SaveImageAs)
            {
                browser.GetHost().StartDownload(parameters.SourceUrl);
            }
            if ((int)commandId == CopyImage)
            {
               // Clipboard.SetImage(parameters.HasImageContents);
            }
            if ((int)commandId == SaveLinkAs)
            {
                browser.GetHost().StartDownload(parameters.LinkUrl);
            }
           
            if ((int)commandId == CopyLinkAddress)
            {
                Clipboard.SetText(parameters.LinkUrl);
            }
   

            if ((int)commandId == SaveAsPdf)
            {
                PdfPrintSettings settings = new PdfPrintSettings();
                settings.Landscape = true;
                settings.BackgroundsEnabled = false;
               
                browser.PrintToPdfAsync(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TorBrowser.pdf", settings);
            }
            return false;
        }

        void IContextMenuHandler.OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        bool IContextMenuHandler.RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
