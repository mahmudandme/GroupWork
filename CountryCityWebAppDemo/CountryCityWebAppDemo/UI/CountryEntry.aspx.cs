using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebAppDemo.BLL;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.UI
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryEntryBLL countryEntryBll = new CountryEntryBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCountry();
        }


        public void GetAllCountry()
        {
           countryEntryGridView.DataSource =  countryEntryBll.GetAllCountries();
            countryEntryGridView.DataBind();
        }

        protected void countryEntryGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "S#";
                e.Row.Cells[0].Width = 40;
                e.Row.Cells[1].Width = 100;
                e.Row.Cells[2].Width = 300;                               
            }
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.Name = countryNameTextBox.Text;
            country.About = aboutCountryTextBox.Text;
            if (countryEntryBll.IsCountryExist(country.Name))
            {
              Response.Write("Country already exist");  
            }
            else
            {
                if (countryEntryBll.SaveCountry(country) > 0)
                {
                    GetAllCountry();
                    Response.Write("Saved");

                }
                else
                {
                    Response.Write("Not saved");
                } 
            }            
        }               
    }
}