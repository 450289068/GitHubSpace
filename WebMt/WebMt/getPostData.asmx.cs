using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace WebMt
{
    /// <summary>
    /// getPostData 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class getPostData : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int loginPostData()
        {
            int intReturn = 0;


            return intReturn;
        }
    }
}
