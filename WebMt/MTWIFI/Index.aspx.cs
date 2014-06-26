using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WIFIMODEL;

namespace MTWIFI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                WFProvider wpserver = new WFProvider();
                if (Request != null)
                {
                    if (Request.QueryString[""] != null && Request.QueryString[""].ToString()!="")
                    { 
                        wpserver.
                    }
                }
            }
            catch (Exception request)
            {
                CommonLib.LogHelper.LogDebug("Index_Requset:"+request.Message);
            }
        }
    }
}