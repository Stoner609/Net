using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Json = Newtonsoft.Json;

namespace WebMethod
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod(enableSession: true)]
        public static string GetMethod(string req)
        {
            var myResponse = new
            {
                EnglishName = "Stoner",
                ChineseName = "石頭人",
                Response = req,
            };

            return Newtonsoft.Json.JsonConvert.SerializeObject(myResponse, Json.Formatting.None);
        }
    }
}