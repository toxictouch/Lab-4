using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Quotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Quote> quotes = (List<Quote>)Session["UserQuotes"];

            foreach (Quote quote in quotes)
            {
                txtQuoteList.Text = quote.ToString();
            }
        }
    }
}