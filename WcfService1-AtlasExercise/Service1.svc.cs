using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WcfService1_AtlasExercise
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /*public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            DataTable resourceTable = new DataTable();
            SqlDataReader resultReader = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("usp_DataSelect", connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                resultReader = command.ExecuteReader();
                resourceTable.Load(resultReader);
                resultReader.Close();
                connection.Close();
                customerList = (from DataRow dr in resourceTable.Rows
                                select new Customer()
                                { Id = Convert.ToInt32(dr["id"]),
                                    FirstName = dr["first_name"].ToString(),
                                    LastName = dr["last_name"].ToString(),
                                    Email = dr["email"].ToString(),
                                    Address1 = dr["address_1"].ToString(),
                                    Address2 = dr["address_2"].ToString(),
                                    City = dr["city"].ToString(),
                                    State = dr["state"].ToString(),
                                    Zip = dr["zip"].ToString(),
                                    Country = dr["country"].ToString()
                                }).ToList();
            }
            catch (Exception exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
            return customerList;
        }

        public void AddCustomers(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("usp_dataInsert", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@first_name", customer.FirstName));
                    command.Parameters.Add(new SqlParameter("@last_name", customer.LastName));
                    command.Parameters.Add(new SqlParameter("@email", customer.Email));
                    command.Parameters.Add(new SqlParameter("@address_1", customer.Address1));
                    command.Parameters.Add(new SqlParameter("@address_2", customer.Address2));
                    command.Parameters.Add(new SqlParameter("@city", customer.City));
                    command.Parameters.Add(new SqlParameter("@state", customer.State));
                    command.Parameters.Add(new SqlParameter("@zip", customer.Zip));
                    command.Parameters.Add(new SqlParameter("@country", customer.Country));

                    object result = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (SqlException exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }
        public void UpdateCustomers(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("usp_dataUpdate", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@id", customer.Id));
                    command.Parameters.Add(new SqlParameter("@first_name", customer.FirstName));
                    command.Parameters.Add(new SqlParameter("@last_name", customer.LastName));
                    command.Parameters.Add(new SqlParameter("@email", customer.Email));
                    command.Parameters.Add(new SqlParameter("@address_1", customer.Address1));
                    command.Parameters.Add(new SqlParameter("@address_2", customer.Address2));
                    command.Parameters.Add(new SqlParameter("@city", customer.City));
                    command.Parameters.Add(new SqlParameter("@state", customer.State));
                    command.Parameters.Add(new SqlParameter("@zip", customer.Zip));
                    command.Parameters.Add(new SqlParameter("@country", customer.Country));

                    object result = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (SqlException exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
        }
    }
}
