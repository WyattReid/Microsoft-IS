using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Lab2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Debug.WriteLine("Application Started");
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Posts"] = new List<BlogPost>()
            {
                new BlogPost(){
                    PostTitle = "My First Blog Post"
                    ,
                    PostBody = "<p>Lorem ipsum dolor sit amet... "
                    ,
                    PostDate = DateTime.Parse("1/13/2013")
                    ,
                    Author = "Jeff"
                }
            };
        }

    }


}
