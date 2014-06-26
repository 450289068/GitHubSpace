using System;
using System.Collections.Generic;
using System.Text;

namespace WIFIMODEL
{
    public class WFProvider
    {
        public WFProvider()
        { }

        //认证服务器的地址
        private string _gwaddr = string.Empty;

        public string Gwaddr
        {
            get { return _gwaddr; }
            set { _gwaddr = value; }
        }
        //路由器MAC地址
        private string _gwmac = string.Empty;

        public string Gwmac
        {
            get { return _gwmac; }
            set { _gwmac = value; }
        }
        //用户Mac地址
        private string _usermac = string.Empty;

        public string Usermac
        {
            get { return _usermac; }
            set { _usermac = value; }
        }
        //用户强制跳转要访问的地址
        private string _gourl = string.Empty;

        public string Gourl
        {
            get { return _gourl; }
            set { _gourl = value; }
        }

        //在线人数
        private string _usernum = string.Empty;

        public string Usernum
        {
            get { return _usernum; }
            set { _usernum = value; }
        }

        //路由器wan管理端口
        private string _gwport = string.Empty;

        public string Gwport
        {
            get { return _gwport; }
            set { _gwport = value; }
        }

        private DateTime _linetime;

        //public DateTime Linetime
        //{
        //    get { return _linetime; }
        //    set { _linetime = value; }
        //}


    }
}
