<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFWebApp_AtlasExercise._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Atlas Brands Customer Search</h1>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        Customer Id: <asp:TextBox ID="txtCustomerId" runat="server" Enabled="false" CssClass="form-control" />
        *First Name:  <asp:TextBox ID="txtFirstName" runat="server"  CssClass="form-control" required="required"></asp:TextBox>
        *Last Name:   <asp:TextBox ID="txtLastName" runat="server"  CssClass="form-control" required="required"></asp:TextBox>
        *Email:   <asp:TextBox ID="txtEmail" runat="server"  CssClass="form-control" required="required"></asp:TextBox>
        Address: <asp:TextBox ID="txtAddress1" runat="server"  CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtAddress2" runat="server"  CssClass="form-control"></asp:TextBox>
        City: <asp:TextBox ID="txtCity" runat="server"  CssClass="form-control"></asp:TextBox>
        State: <asp:TextBox ID="txtState" runat="server"  CssClass="form-control" ></asp:TextBox>
        Zip: <asp:TextBox ID="txtZip" runat="server"  CssClass="form-control"></asp:TextBox>
        Country: <asp:TextBox ID="txtCountry" runat="server"  CssClass="form-control"></asp:TextBox>
                <asp:Button ID="ButtonInsert" runat="server" Text="Add" OnClick="InsertButton_Click"  CssClass="btn btn-primary btn-lg"/>
                <asp:Button ID="ButtonUpdate" runat="server" visible="false" Text="Update" OnClick="UpdateButton_Click"  CssClass="btn btn-primary btn-lg"/>
        <br />
        <br />
        *required
    </div>
    <div class="jumbotron">
        <asp:GridView ID="GridViewCustomerDetails" DataKeyNames="Id" AutoGenerateColumns="false"
            runat="server" OnSelectedIndexChanged="GridViewCustomerDetails_SelectedIndexChanged">

            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnSelect" runat="server" CommandName="Select" Text="Select" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                        <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("FirstName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Last Name">
                    <ItemTemplate>
                        <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("LastName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label ID="lblAddress1" runat="server" Text='<%#Eval("Address1") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label ID="lblAddress2" runat="server" Text='<%#Eval("Address2") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label ID="lblState" runat="server" Text='<%#Eval("State") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Zip">
                    <ItemTemplate>
                        <asp:Label ID="lblZip" runat="server" Text='<%#Eval("Zip") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        <asp:Label ID="lblCountry" runat="server" Text='<%#Eval("Country") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
