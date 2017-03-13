using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = "张三";

            Session["a"] = 1;

            People p = new People();
            p.name = "小白";
            p.Age = 100;
            Session["p"] = p;

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(Session["a"]);
            Response.Write(Session["name"]);

            People p = Session["p"] as People;
            Response.Write(p.name);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Remove("name");
        }
    }

    [Serializable]
    public class People
    {
        public string name { get; set; }

        public int Age { get; set; }

        public double money { get; set; }
    }
}