using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using CommonLib;

namespace MTWIFI
{
    public partial class hb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request == null) return;

            if (Request.RequestType.ToUpper() == "POST")
            {
                LogHelper.LogDebug("DataFromPost");
            }
            else
            {
                LogHelper.LogDebug("DataFromGET");
            }
        }
    }
}