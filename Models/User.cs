using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PcPhoneCommunicatorWeb.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string GcmId { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                    "api/user/{0}", this.UserId);
            }
            set { }
        }
    }
}