using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Page Load");
            var posts = Application["Posts"] as List<BlogPost>;
            Debug.WriteLine(posts);

            if (posts != null)
            {
                
                PostList.DataSource = posts;
                PostList.DataBind();
            }


        }
    }
}