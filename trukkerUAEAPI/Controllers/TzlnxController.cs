﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace trukkerUAE.Controllers
{
    public class TzlnxController : ApiController
    {
        // GET api/tzlnx
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/tzlnx/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tzlnx
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tzlnx/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tzlnx/5
        public void Delete(int id)
        {
        }

        public void Test_func()
        { 
            //avdvvdvvddvv
            //Test
            //Test2
            //Test3
            //Test4
            //test5
        }
    }
}
