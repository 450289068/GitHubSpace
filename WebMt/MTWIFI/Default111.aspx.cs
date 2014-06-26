using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using CommonLib;



//王斌 20140420 通过参数获取当前所有参数，通过Request.Type来区分Get，post方法来判断如何处理参数值。
namespace MTWIFI
{


    public partial class _Default : System.Web.UI.Page
    {
        public WIFIMODEL.WFProvider wfp = new WIFIMODEL.WFProvider();
        public string APIURL = string.Empty;
        public string GoURL = string.Empty;
        /// <summary>
        /// Request.RequestType可以判别是get还是post，取请求内容都可以用Request["sn"]，get,post通用。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request == null) return;

            if (Request.RequestType.ToUpper() == "POST")
            {
                SortedList table = Param();
                if (table != null)
                {
                    foreach (DictionaryEntry De in table) 
                    { 
                        
                    }
                }
                else
                { }
            }
            else
            {
                //"GET";
                NameValueCollection nvc = GETInput();
                if (nvc.Count != 0)
                {
                    for (int i = 0; i < nvc.Count; i++) 
                    { 
                        if(nvc.GetKey(i)=="gwmac")
                        {
                            wfp.Gwmac = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Gwmac);
                        }
                        if (nvc.GetKey(i) == "mac")
                        {
                            wfp.Usermac = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Usermac);
                        } 
                        if (nvc.GetKey(i) == "gwaddr")
                        {
                            wfp.Gwaddr = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Gwaddr);
                        } 
                        if (nvc.GetKey(i) == "url")
                        {
                            wfp.Gourl = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Gourl);
                        }
                        if (nvc.GetKey(i) == "gwport")
                        {
                            wfp.Gwport = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Gwport);
                        } 
                        if (nvc.GetKey(i) == "usernum")
                        {
                            wfp.Usernum = nvc.GetValues(i)[0];
                            LogHelper.LogDebug(wfp.Usernum);
                        }
                    }
                }
                else
                {  }
            }


            if (!string.IsNullOrEmpty(wfp.Gwaddr))
            {
                APIURL = "http://" + wfp.Gwaddr + "/api/login.cgi";
            }
            else
            {
                APIURL = "http://1.1.1.1/api/webauth";
            }

            if (!string.IsNullOrEmpty(wfp.Gourl))
            {
                GoURL = wfp.Gourl;
            }
            else
            {
                GoURL = "http://wap.baidu.com";
            }

        }

        //获取GET返回来的数据
        private NameValueCollection GETInput()
        { return Request.QueryString; }
        // 获取POST返回来的数据
        private string PostInput()
        {
            try
            {
                System.IO.Stream s = Request.InputStream;
                int count = 0;
                byte[] buffer = new byte[1024];
                StringBuilder builder = new StringBuilder();
                while ((count = s.Read(buffer, 0, 1024)) > 0)
                {
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, count));//utf-8编码
                }
                s.Flush();
                s.Close();
                s.Dispose();
                return builder.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private SortedList Param()
        {
            string POSTStr = PostInput();
            SortedList SortList = new SortedList();
            int index = POSTStr.IndexOf("&");
            string[] Arr = { };
            if (index != -1) //参数传递不只一项
            {
                Arr = POSTStr.Split('&');
                for (int i = 0; i < Arr.Length; i++)
                {
                    int equalindex = Arr[i].IndexOf('=');
                    string paramN = Arr[i].Substring(0, equalindex);
                    string paramV = Arr[i].Substring(equalindex + 1);
                    if (!SortList.ContainsKey(paramN)) //避免用户传递相同参数
                    { SortList.Add(paramN, paramV); }
                    else //如果有相同的，一直删除取最后一个值为准
                    { SortList.Remove(paramN); SortList.Add(paramN, paramV); }
                }
            }
            else //参数少于或等于1项
            {
                int equalindex = POSTStr.IndexOf('=');
                if (equalindex != -1)
                { //参数是1项
                    string paramN = POSTStr.Substring(0, equalindex);
                    string paramV = POSTStr.Substring(equalindex + 1);
                    SortList.Add(paramN, paramV);
                }
                else //没有传递参数过来
                { SortList = null; }
            }
            return SortList;
        }

    }
}