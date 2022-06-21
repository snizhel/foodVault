using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class CustomerDAO : GeneralDAO
    {
        public List<Customer> getAllCustomers()
        {
            List<Customer> lst = new List<Customer>();

            DataSet ds = getAll("Customer");
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Customer customer = new Customer()
                {
                    CustomerId = int.Parse(dr["CustomerId"].ToString()),
                    DisplayNameCustomer = dr["DisplayNameFood"].ToString()
                };
                lst.Add(customer);
            }

            return lst;

        }
        public DataSet getAllCustomer()
        {
            return getAll("Customer");
        }
        public DataSet searchByName(string name)
        {
            return search("Customer", "DisplayNameCustomer like '%" + name + "%' or " +
                                      "DisplayNameCustomer like '%" + name + "%' ");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Customer", " CustomerId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteCustomer(int id)
        {
            try
            {
                string sql = "delete [Customer] where CustomerId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateCustomer(Customer customer)
        {
            try
            {
                string sql = "update [Customer] set DisplayNameCustomer = '" + customer.DisplayNameCustomer + "', " +
                                                 "Address = '" + customer.Address + "', " +
                                                 "Phone = '" + customer.Phone + "', " +
                                                 "Email = '" + customer.Email + "', " +
                                                 "MoreInfo = '" + customer.MoreInfo + "', " +
                                                 "ContractDate = '" + customer.ContractDate.ToString("MM/dd/yyyy") + "' " +
                                                 "where CustomerId = '" + customer.CustomerId + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createCustomer(Customer customer)
        {
            try
            {
                string sql = "insert into [Customer] (DisplayNameCustomer, Address, Phone, Email, MoreInfo, ContractDate) " +
                             "values ('" + customer.DisplayNameCustomer + "', '" + customer.Address + "', '" + customer.Phone + "', '" + customer.Email + "', '" + customer.MoreInfo + "', '" + customer.ContractDate.ToString("MM/dd/yyyy") + "')";
                return insert_update_delete(sql);// -1 if error

            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
    }
}
