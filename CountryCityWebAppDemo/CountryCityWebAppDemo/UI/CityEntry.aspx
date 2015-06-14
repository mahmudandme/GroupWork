<%@ Page Title="" Language="C#" MasterPageFile="~/UI/MasterPage.Master" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryCityWebAppDemo.UI.CityEntry" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/CityEntryStylesheet.css" rel="stylesheet" />
    

    <div class="cityEntryWrapper">   
        <div class="cityEntryContainer">
            <div class="cityEntryHeaderText">
                <h1>City Entry</h1>
            </div>
            <div class="cityEntryContent">
            <div class="nameEntryDiv">
                <div class="nameText">
                    <h1>Name :</h1>
                </div>
                
                <div class="nameTextBoxDiv">
                    <asp:TextBox ID="cityNameTextBox" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </div>
            </div>
            
            <div class="aboutEntryDiv">
              <div class="aboutText">
                    <h1>About :</h1>
                </div>
                
                <div class="aboutTextBoxDiv">
                    <asp:TextBox ID="aboutCityTextBox" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </div>  
            </div>
                
                
                <div class="nOfDwDiv">
                <div class="numberOfDwlText">
                    <h1>Number of dwellers :</h1>
                </div>
                
                <div class="numberOfDwlTextBox">
                    <asp:TextBox ID="numberOfDwellersTextBox" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </div>
            </div>
                
                <div class="locationEntryDiv">
                <div class="locationText">
                    <h1>Location :</h1>
                </div>
                
                <div class="locationTextBoxDiv">
                    <asp:TextBox ID="locationTextBox" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </div>
            </div>
                
             
                 <div class="weatherEntryDiv">
              <div class="weatherText">
                    <h1>Weather :</h1>
                </div>
                
                <div class="weatherTextBoxDiv">
                    <asp:TextBox ID="weatherTextBox" runat="server" Height="70px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </div>  
            </div>   

                
                <div class="countryEntryDiv">
                <div class="countryText">
                    <h1>Country :</h1>
                </div>
                
                <div class="countryDropdown">
                    <asp:DropDownList ID="countryDropDownList" runat="server" Width="205px" Height="25px"></asp:DropDownList>
                </div>
            </div>

                

         </div>
            <div class="saveButtonDiv">
                <div>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="86px" Height="30px" Font-Bold="True" OnClick="saveButton_Click"/>
                </div>
                
            </div>

        </div>

        <div class="gridViewDiv">
           
             <asp:GridView ID="cityGridView" runat="server" CssClass="cityEntryGridView" OnRowDataBound="cityGridView_RowDataBound">

            </asp:GridView>
        </div>
    </div>  
    
    

</asp:Content>
