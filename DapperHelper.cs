using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dapper4Lee
{
    public class DapperHelper
    {
        private static object LOCKOBJ = new object(); 
        private DapperHelper()
        { } 
        private static DapperHelper _Instance;
        public static DapperHelper Instance
        {
            get
            {
                if(_Instance==null)
                {
                    lock (LOCKOBJ)
                    {
                        if (_Instance == null)
                            _Instance = new DapperHelper();
                    }
                }
                return _Instance;
            }
        }
    }
}
