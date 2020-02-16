using System;
using System.Collections.Generic;
using System.Text;

namespace Masmusculo.Configuration
{
    class Constants
    {
        // URL for login page
        public static string LoginUrl { get { return "https://app.masmusculo.fit/login"; } }
        // webview URL for register page
        public static string RegisterUrl { get { return "https://app.masmusculo.fit/register/"; } }
        // webview URL for recoverypassword page
        public static string RecoveryPasswordUrl { get { return "https://app.masmusculo.fit/resetting/request"; } }
    }
}
