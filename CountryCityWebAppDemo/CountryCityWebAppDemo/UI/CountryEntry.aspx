<%@ Page Title="" Language="C#" MasterPageFile="~/UI/MasterPage.Master" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryCityWebAppDemo.UI.CountryEntry" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/CountryEntryStylesheet.css" rel="stylesheet" />
    
    <div class="wrapper1">
        <div class="container1">
            <div class="contentHead">
                <h1>Country Entry</h1>
            </div>
            <div class="nameAboutContent">
            <div class="nameWrapper">
                <div class="nameContent">
                    <h1>Name :</h1>
                </div>
                
                <div class="countryTextBoxContent">
                    <asp:TextBox ID="countryNameTextBox" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </div>
            </div>
            
            <div class="aboutWrapper">
              <div class="aboutContent">
                    <h1>About :</h1>
                </div>
                
                <div class="aboutTextBoxContent">
                    <asp:TextBox ID="aboutCountryTextBox" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </div>  
            </div>
         </div>
            <div class="buttonWrapper">
                <div>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="86px" Height="30px" Font-Bold="True" OnClick="saveButton_Click"/>
                </div>
                
            </div>

        </div>

        <div class="gridViewWrapper">
            <asp:GridView CssClass="countryGridView" ID="countryEntryGridView" runat="server" OnRowDataBound="countryEntryGridView_RowDataBound">

            </asp:GridView>
        </div>
    </div>
</asp:Content>
