using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class CreatePost : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }

        private void AddPost(BlogPost post)
        {
            var postList = Application["Posts"] as List<BlogPost>;
            if (postList != null)
            {
                postList.Add(post);
                Application["Posts"] = postList;
                Debug.WriteLine("Post Title: " +post.PostTitle);
                Debug.WriteLine("Post Body: " +post.PostBody);
                Debug.WriteLine("Post Author: " +post.Author);
                Debug.WriteLine("Post Date: " +post.PostDate);
                
            }
        }


        protected void postButton_Click(object sender, EventArgs e)
        {
            var newPost = new BlogPost
            {
                Author = Context.User.Identity.Name,
                PostDate = DateTime.Now,
                PostBody = System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(postBox.Text, false),
                PostTitle = System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(titleBox.Text, false),
            };


            AddPost(newPost);
            Response.Redirect("Default.aspx");
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            postBox.Text = "";
            titleBox.Text = "";
        }
    }
}