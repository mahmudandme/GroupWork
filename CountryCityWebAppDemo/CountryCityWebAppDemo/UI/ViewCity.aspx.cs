using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebAppDemo.BLL;

namespace CountryCityWebAppDemo.UI
{
    public partial class ViewCity : System.Web.UI.Page
    {
        SearchCityBLL searchCityBLL = new SearchCityBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                GetAllCountryInDropDownList();
                GetAllCityInformationInGridVew();
            }
            
        }

        public void GetAllCountryInDropDownList()
        {
            countryDropDownList.DataSource = searchCityBLL.GetAllCountryName();
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataValueField = "ID";
            countryDropDownList.DataBind();
        }

        public void GetAllCityInformationInGridVew()
        {
            citySearchGridView.DataSource = searchCityBLL.GetAllCityInfromation();
            citySearchGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (cityRadioButton.Checked)
            {
                
                citySearchGridView.DataSource = searchCityBLL.GetIntendedCityInfromation(Convert.ToString(citySearchTextBox.Text));
                citySearchGridView.DataBind();
            }
            else
            {
                if (countryRadioButton.Checked)
                {
                    citySearchGridView.DataSource = searchCityBLL.GetIntendedCityInformationByCountryName(countryDropDownList.SelectedItem.Text);
                    citySearchGridView.DataBind();
                } 
            }
        }

        protected void cityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            citySearchTextBox.Text = "";
            GetAllCityInformationInGridVew();
        }
    }
}