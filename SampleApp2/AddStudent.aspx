<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="SampleApp2.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Student Page</h1>
<p>Student Name</p>
<asp:TextBox ID="NameBox" runat="server" Width="279px" BorderStyle="Solid"></asp:TextBox>
<p>Registered Number</p>
<asp:TextBox ID="NumberBox" runat="server" Width="279px" BackColor="White" BorderStyle="Solid"></asp:TextBox>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Con" DataTextField="CategoryName" DataValueField="CategoryName" Height="16px" Width="285px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="Con" runat="server" ConnectionString="<%$ ConnectionStrings:TrainingConnectionString %>" SelectCommand="SELECT [CategoryName] FROM [Category]"></asp:SqlDataSource>
    </p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Student" Width="283px" />
<p>
    <asp:Label ID="LabelAddStudent" runat="server" Text="Label"></asp:Label>
</p>
<p>&nbsp;</p>
</asp:Content>
