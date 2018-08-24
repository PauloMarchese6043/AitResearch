using AitResearch.DbTableModels;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace AitResearch
{
    public partial class StaffSearch : System.Web.UI.Page
    {
        private static DatabaseContext dbContext = new DatabaseContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = dbContext.SESSIONS.ToList();
            GridView1.DataBind();
        }
    }
}