using System;
using System.Threading;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace ersOWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Config>("http://localhost:8099");
            Thread.Sleep(-1);
        }
    }

    public class TimeController : ApiController
    {
        [HttpGet]
        [Route("time")]
        public string WhatTime() => $"hello, it's {DateTime.Now}";
    }

    public class Config
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            app.UseWebApi(config);
        }
    }
}
