using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        DataTable dt = new DataTable();
        public string GetTest()
        {
            return "asdf";
        }

        
        public DataTable GetTable()
        {
            dt.TableName = "test";
            dt.Columns.Add("ID", typeof(String));
            dt.Columns.Add("Name", typeof(String));

            DataRow dr = dt.NewRow();
            dt.Rows.Add(new Object[]{"1", "Name1"});

            return dt;
        }
    }
}
