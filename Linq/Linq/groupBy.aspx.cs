using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class groupBy : System.Web.UI.Page
    {
        class Person
        {
            internal int PersonID;
            internal string car;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { PersonID = 1, car = "Ferrari" });
            persons.Add(new Person() { PersonID = 1, car = "BMW" });
            persons.Add(new Person() { PersonID = 2, car = "Audi" });

            // 一般我會的寫法linq
            //var results = from p in persons
            //              group p.car by p.PersonID into g
            //              select new { 
            //                  PersonId = g.Key, 
            //                  Cars = g.ToList()
            //              };

            // 一般我會寫的lambda
            var results = persons.GroupBy(
                p => p.PersonID,
                p => p.car,
                (key, g) => new { PersonId = key, Cars = g.ToList() });

            foreach ( var item in results )
            {
                Response.Write(string.Format("PersonId: {0} <br>", item.PersonId));
                foreach ( var item2 in item.Cars )
                {
                    Response.Write("car: " + item2 + "<br>");
                }
                Response.Write("<hr/>");
            }

            // 一般我會寫的Lambda 之二
            var results2 = persons.GroupBy(x => x.PersonID)
                            .Select(c => new {
                                PersonId = c.Key,
                                Cars = c.ToList()
                            });
            foreach ( var item in results2 )
            {
                Response.Write(string.Format("PersonId: {0} <br>", item.PersonId));
                foreach ( var item2 in item.Cars )
                {
                    Response.Write("car: " + item2.car + "<br>");
                }
                Response.Write("<hr/>");
            }

            // -----------------------------------------------------------

            //同事的寫法，學習嚕~
            //var results = from o in persons
            //              group new {
            //                  personid = o.PersonID,
            //                  car = o.car
            //              } by o.PersonID;

            //foreach ( var item in results )
            //{
            //    Response.Write(string.Format("數量: {0}, PersonId: {1}<br>",item.Count(), item.Key));
            //    foreach ( var item2 in item )
            //    {
            //        Response.Write("Car: " + item2.car + "<br/>");
            //    }
            //    Response.Write("<hr/>");
            //}
        }
    }
}