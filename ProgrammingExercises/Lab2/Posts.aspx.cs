using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Posts : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            var title = Request.QueryString["Title"];
            var posts = Application["Posts"] as List<BlogPost>;
            if (posts != null)
            {
                var post = posts.FirstOrDefault(bp => bp.PostTitle == title);
                if (post != null)
                {
                    authorDisplay.Text = post.Author;
                    titleDisplay.Text = post.PostTitle;
                    bodyDisplay.Text = post.PostBody;
                    dateDisplay.Text = post.PostDate.ToString("d");
                }
            }



        }
    }
}