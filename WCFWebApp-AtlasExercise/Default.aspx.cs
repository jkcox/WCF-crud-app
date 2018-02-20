using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFWebApp_AtlasExercise.ServiceReference1;
using System.ServiceModel;

namespace WCFWebApp_AtlasExercise
{
    public partial class _Default : Page
    {
        ServiceReference1.Service1Client proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    proxy = new ServiceReference1.Service1Client();
                    GridViewCustomerDetails.DataSource = proxy.GetCustomers();
                    GridViewCustomerDetails.DataBind();
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    lblMsg.Text = "Error while loading customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
                catch (Exception exception)
                {
                    lblMsg.Text = "Error while loading customer details :" + exception.Message;
                }
            }
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = 0;
                string FirstName = txtFirstName.Text.Trim();
                string LastName = txtLastName.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string Address1 = txtAddress1.Text.Trim();
                string Address2 = txtAddress2.Text.Trim();
                string City = txtCity.Text.Trim();
                string State = txtState.Text.Trim();
                string Zip = txtZip.Text.Trim();
                string Country = txtCountry.Text.Trim();

                proxy = new ServiceReference1.Service1Client();
                ServiceReference1.Customer newCustomer =
                new ServiceReference1.Customer()
                {
                    Id = Id,
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Address1 = Address1,
                    Address2 = Address2,
                    City = City,
                    State = State,
                    Zip = Zip,
                    Country = Country
                };

                proxy.AddCustomers(newCustomer);

                GridViewCustomerDetails.DataSource = proxy.GetCustomers();
                GridViewCustomerDetails.DataBind();
                lblMsg.Text = "Record Saved Successfully";
            }
            catch (FaultException<ExceptionMessage> exceptionFromService)
            {
              lblMsg.Text = "Error while adding new customer details :" + exceptionFromService.Detail.errorMessageOfAction;

            }
            catch (Exception exception)
            {
              lblMsg.Text = "Error while adding new customer details :" + exception.Message;
            }

            ResetAll();
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtCustomerId.Text);
                string FirstName = txtFirstName.Text.Trim();
                string LastName = txtLastName.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string Address1 = txtAddress1.Text.Trim();
                string Address2 = txtAddress2.Text.Trim();
                string City = txtCity.Text.Trim();
                string State = txtState.Text.Trim();
                string Zip = txtZip.Text.Trim();
                string Country = txtCountry.Text.Trim();

                proxy = new ServiceReference1.Service1Client();
                ServiceReference1.Customer oldCustomer =
                new ServiceReference1.Customer()
                {
                    Id = Id,
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Address1 = Address1,
                    Address2 = Address2,
                    City = City,
                    State = State,
                    Zip = Zip,
                    Country = Country
                };

                proxy.UpdateCustomers(oldCustomer);

                GridViewCustomerDetails.DataSource = proxy.GetCustomers();
                GridViewCustomerDetails.DataBind();
                lblMsg.Text = "Record Updated Successfully";
            }
            catch (FaultException<ExceptionMessage> exceptionFromService)
            {
                    lblMsg.Text = "Error while updating customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                
            }
            catch (Exception exception)
            {
                    lblMsg.Text = "Error while updating customer details :" + exception.Message;
            }

            ResetAll();
        }
        protected void GridViewCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerId.Text = GridViewCustomerDetails.DataKeys[GridViewCustomerDetails.SelectedRow.RowIndex].Value.ToString();
            txtFirstName.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblFirstName") as Label).Text;
            txtLastName.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblLastName") as Label).Text;
            txtEmail.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblEmail") as Label).Text;
            txtAddress1.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblAddress1") as Label).Text;
            txtAddress2.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblAddress2") as Label).Text;
            txtCity.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblCity") as Label).Text;
            txtState.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblState") as Label).Text;
            txtZip.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblZip") as Label).Text;
            txtCountry.Text = (GridViewCustomerDetails.SelectedRow.FindControl("lblCountry") as Label).Text;
         
            //make invisible Insert button during update/delete
            ButtonInsert.Visible = false;
            ButtonUpdate.Visible = true;
        }

        private void ResetAll()
        {
            ButtonInsert.Visible = true;
            ButtonUpdate.Visible = false;
            txtCustomerId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtCountry.Text = "";

        }

    }
}