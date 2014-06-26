using System;
using System.Collections.Generic;
using System.Text;

namespace WIFIMODEL
{
    /// <summary>
    /// 商家信息表
    /// </summary>
    public class Provider
    {
        public Provider()
        { }

        //商家名称
        private string _pname = string.Empty;

        public string Pname
        {
            get { return _pname; }
            set { _pname = value; }
        }

        //商家地址
        private string _paddress = string.Empty;

        public string Paddress
        {
            get { return _paddress; }
            set { _paddress = value; }
        }

        //商家电话
        private string _ptel = string.Empty;

        public string Ptel
        {
            get { return _ptel; }
            set { _ptel = value; }
        }

        //商家mac
        private string _pmac = string.Empty;

        public string Pmac
        {
            get { return _pmac; }
            set { _pmac = value; }
        }

        //等级
        private string _plevel = string.Empty;

        public string Plevel
        {
            get { return _plevel; }
            set { _plevel = value; }
        }

        //商家类型
        private string _ptype = string.Empty;

        public string Ptype
        {
            get { return _ptype; }
            set { _ptype = value; }
        }

        
    }
}
