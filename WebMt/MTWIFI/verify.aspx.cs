using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace MTWIFI
{
    public partial class verify : System.Web.UI.Page
    {
        public string stringToken = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            string tokentemp = getToken();

            Response.Write("{\"ret\":\"1\",\"token\":\"" + tokentemp + "\"}");
        }

        public string getToken()
        {
            string token = "";

            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dtNow = DateTime.Parse(DateTime.Now.ToString());
            TimeSpan toNow = dtNow.Subtract(dtStart);
            string timeStamp = toNow.Ticks.ToString();
            timeStamp = timeStamp.Substring(0, timeStamp.Length - 7);

            int token_livetime = 180;
            string slat_string = "mtwifi";

            int tmp = (Convert.ToInt32(timeStamp) / token_livetime);
            token = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tmp.ToString() + slat_string, "MD5").ToLower();

            return token;
        }
    }
}