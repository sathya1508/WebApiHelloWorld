using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelloWorld.Controllers
{
    public class BooksController : ApiController
    {
        public List<books> GetBooks()
        {
            DBConn db = new DBConn();

            return db.dbbooks.ToList();
        }
    }
}
