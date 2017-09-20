using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hello.Models
{
    public class DbConnector
    {
        public DbConnector()
        {
            return;
        }

        public Dictionary<int, string> query(string query)
        {
            var n = new Dictionary<int, string>();
            n.Add(0, "Hello World");
            return n;
        }
    }

    public class DatabaseFrameworkModel
    {
        public DbConnector db = new DbConnector();
    }

    public class Data : DatabaseFrameworkModel // i.e., entity framework, etc.
    {
        public string Message { get; set; } // Not used but useful if real framework used

        public string GetData()
        {
            try
            {
                var response = db.query("select message from data where id = 1")[0];
                return response;
            }
            catch
            {
                return "Hello World";
            }
        }
    }
}