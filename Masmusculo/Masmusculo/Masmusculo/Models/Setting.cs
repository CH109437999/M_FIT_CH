using System;
using System.Collections.Generic;
using System.Text;

namespace Masmusculo.Models
{
    class Setting
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime AccessTokenexpiration { get; set; }
    }
}
