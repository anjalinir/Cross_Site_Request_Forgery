using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STP
{
    public static class Session_
    {
        private static HttpCookie sessionCookie = new HttpCookie("Session_Id");
        public static HttpCookie SessionCookie
        {
            get { return sessionCookie; }
            set { sessionCookie = value; }
        }

        private static string _antiXsrfTokenValue;
        public static string _AntiXsrfTokenValue
        {
            get { return _antiXsrfTokenValue; }
            set { _antiXsrfTokenValue = value; }
        }

        private static Hashtable htSessions = new Hashtable();
        public static Hashtable HtSessions
        {
            get { return htSessions; }
            set { htSessions = value; }
        }


    }
}