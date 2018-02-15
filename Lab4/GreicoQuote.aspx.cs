using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class GreicoQuote : System.Web.UI.Page
    {
        public List<Quote> UserQuotes;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserQuotes"] != null)
            {
                UserQuotes = (List<Quote>)Session["UserQuotes"];
            }
            else
            {
                UserQuotes = new List<Quote>();
                Session["UserQuotes"] = UserQuotes;

            }
            txtQuote.Enabled = false;
            lblMake.Visible = false;
            ddlMake.Visible = false;
            lblModel.Visible = false;
            ddlModel.Visible = false;
            if (!IsPostBack)
            {
                var years = CarData.Vehicles.Select(c => c.Year).Distinct().Reverse();

                foreach (int year in years)
                {
                    ddlYear.Items.Add(new ListItem(year.ToString(), year.ToString()));
                }

                for(int x = 16; x <= 100; x++)
                {
                    ddlAge.Items.Add(Convert.ToString(x));
                }

                rblType.Items.Add("Liability");
                rblType.Items.Add("Comprehensive");
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double price;
            int ageFactor;
            int vioFactor;
            int age = Convert.ToInt32(this.ddlAge.Text);
            int selectedYear = Convert.ToInt32(ddlYear.SelectedValue);
            string selectedMake = ddlMake.SelectedValue;
            string selectedModel = ddlModel.SelectedValue;
            Vehicle vehicle = CarData.Vehicles.Where(v => v.Year == selectedYear & v.Make == selectedMake & v.Model == selectedModel).FirstOrDefault();
            if (age < 22)
            {
                ageFactor = 22 - age;
            }
            else
                ageFactor = 0;

            if (ckbViolation.Checked)
                vioFactor = 1;
            else
                vioFactor = 0;
            if (vehicle == null)
                return;

            //Checks the insurance type and runs the calc for that type
            if(this.rblType.SelectedIndex == 0)
            {
                price = 182.50 + ageFactor * 28.5 + vioFactor * 45.50;
            }

            else 
            {
                int carAge = 2018 - Convert.ToInt32(this.ddlAge.Text);
                double carFactor;
                if (carAge <= 10)
                {
                    carFactor = carAge / 2;
                }
                else
                    carFactor = 5;

                price = 773.50 + (ageFactor * 49.5) + (vioFactor * 52.50) - (carFactor * 32.5);
            }

            Quote quote = new Quote(this.txtFName.Text, this.txtLName.Text, Convert.ToInt32(this.txtZip.Text), Convert.ToInt32(this.ddlYear.Text), this.ddlMake.Text, this.ddlModel.Text, Convert.ToInt32(this.ddlAge.Text), this.rblType.Text, price);
            UserQuotes.Add(quote);
            Session["UserQuotes"] = UserQuotes;
            txtQuote.Text = quote.ToString();
            txtFName.Text = "";
            txtLName.Text = "";
            txtZip.Text = "";
            lblMake.Visible = false;
            ddlMake.Visible = false;
            lblModel.Visible = false;
            ddlModel.Visible = false;
        }

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = Convert.ToInt32(ddlYear.SelectedValue);
            List<String> makes = CarData.Vehicles.Where(v => v.Year == selectedYear).OrderBy(c => c.Make).Select(c => c.Make).Distinct().ToList();
            ddlMake.Items.Clear();

            foreach (string make in makes)
            {
                ddlMake.Items.Add(new ListItem(make, make));
            }
            lblMake.Visible = true;
            ddlMake.Visible = true;
            lblModel.Visible = true;
            ddlModel.Visible = true;

            string selectedMake = ddlMake.Items[0].Value;
            List<String> models = CarData.Vehicles.Where(v => v.Year == selectedYear & v.Make == selectedMake).OrderBy(c => c.Model).Select(c => c.Model).ToList();
            ddlModel.Items.Clear();

            foreach(string model in models)
            {
                ddlModel.Items.Add(new ListItem(model, model));
            }
        }

        protected void ddlMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = Convert.ToInt32(ddlYear.SelectedValue);
            string selectedMake = ddlMake.SelectedValue;
            List<String> models = CarData.Vehicles.Where(v => v.Year == selectedYear & v.Make == selectedMake).OrderBy(c => c.Model).Select(c => c.Model).ToList();
            ddlModel.Items.Clear();

            foreach (string model in models)
            {
                ddlModel.Items.Add(new ListItem(model, model));
            }
            lblMake.Visible = true;
            ddlMake.Visible = true;
            lblModel.Visible = true;
            ddlModel.Visible = true;

        }
    }
}