﻿using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Web.Http;
using Notes.Data;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Checking data...");
                DataProducer.TryFill();

                Console.WriteLine("Service running... Press Enter to EXIT");
                Console.ReadLine();
            }
        }
    }
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
        }
    }
}
