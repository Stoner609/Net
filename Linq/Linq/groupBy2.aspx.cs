using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class groupBy2 : System.Web.UI.Page
    {

        class Transcript
        {
            internal string Class;
            internal int score;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Transcript> transcriptList = new List<Transcript>();
            transcriptList.Add(new Transcript() { Class = "A", score = 100 });
            transcriptList.Add(new Transcript() { Class = "A", score = 90 });
            transcriptList.Add(new Transcript() { Class = "A", score = 80 });
            transcriptList.Add(new Transcript() { Class = "A", score = 60 });
            transcriptList.Add(new Transcript() { Class = "A", score = 50 });
            transcriptList.Add(new Transcript() { Class = "A", score = 50 });
            transcriptList.Add(new Transcript() { Class = "B", score = 95 });
            transcriptList.Add(new Transcript() { Class = "B", score = 80 });
            transcriptList.Add(new Transcript() { Class = "B", score = 80 });

            // 複習
            /*var transcriptListGroupByScore = transcriptList.GroupBy(c => c.score)
                    .Select(c => new
                    {
                        score = c.Key,
                        scoreCount = c.Count()
                    }).OrderByDescending(order => order.score).ToList();

            foreach ( var item in transcriptListGroupByScore )
            {
                Response.Write(string.Format("Score: {0}, Count{1}<br/>", item.score, item.scoreCount));
            }*/

            // 複習
            var transcriptListGroupByScore = transcriptList.GroupBy(c => new { c.Class, c.score })
                    .Select(c => new {
                        Class = c.Key.Class,
                        score = c.Key.score,
                        scoreCount = c.Count()
                    }).OrderBy(order => order.Class).ThenByDescending(order => order.score).ToList();

            foreach ( var item in transcriptListGroupByScore )
            {
                Response.Write(string.Format("Class: {0}, Score: {1}, Count{2}<br/>", item.Class, item.score, item.scoreCount));
            }



        }
    }
}