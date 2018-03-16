using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Json = Newtonsoft.Json;
using System.Web.Script.Services;

namespace WebMethod
{
    public partial class Get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         * UseHttpGet 需要再webconfig啟用HttpGet
         * 如果想要用 asp.net Ajax頁面，必須使用ScriptService屬性，這會創建一個Javascript代理來使用
         * JSON格式來調用Web服務。
         * 
         * 因為默認的WebService不會偵聽Get，並且如果使用GET來調用的話，將引發不支援的錯誤。
         * 為了啟用Get，還必須在Web應用程序的Web.config文件中修改
         *  <system.web>
                ...
                <webServices>
                    <protocols>
                        <add name="HttpGet"/>
                    </protocols>
                </webServices>
               ...
            </system.web>
         */

        [System.Web.Services.WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static string GetMethod(string A, string B)
        {
            var myResponse = new
            {
                EnglishName = "Stoner",
                ChineseName = "石頭人",
                Response = A + B,
            };

            return Newtonsoft.Json.JsonConvert.SerializeObject(myResponse);
        }
    }
}