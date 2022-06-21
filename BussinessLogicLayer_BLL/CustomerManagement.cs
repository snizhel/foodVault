using DataAccessLayer_DAL;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer_BLL
{
    public class CustomerManagement
    {
        CustomerDAO customerDAO = new CustomerDAO();
        //admin
        public DataSet ViewCustomers()
        {
            return customerDAO.getAllCustomer();
        }
        public DataSet searchByName(string name)
        {
            return customerDAO.searchByName(name);
        }


        public SqlDataReader getDatails(string id)
        {
            return customerDAO.findById(id);
        }


        public void closeConnection()
        {
            customerDAO.closeConnection();
        }


        public int AddCustomer(Customer customer)
        {
            // check valid

            //call DAO
            return customerDAO.createCustomer(customer);

        }
        public int UpdateCustomer(Customer customer)
        {
            // check valid

            //call DAO
            return customerDAO.updateCustomer(customer);

        }
        public int RemoveCustomer(int id)
        {
            // check valid

            //call DAO
            return customerDAO.deleteCustomer(id);

        }
        //public bool isExistIdCustomer(int idCustomer)
        //{
        //    List<Customer> lst = customerDAO.getAllCustomers();
        //    foreach (Customer customer in lst)
        //    {
        //        int idCustomer_indb = customer.CustomerId;
        //        if (idCustomer_indb == idCustomer)
        //        {
        //            return true; // tk da ton tai
        //        }

        //    }
        //    return false; // tk chua ton tai
        //}
        //public bool isExistDisplayNameFood(string DisplayNameCustomer)
        //{
        //    List<Customer> lst = customerDAO.getAllCustomers();
        //    foreach (Customer customer in lst)
        //    {
        //        string DisplayNameCustomer_indb = customer.DisplayNameCustomer;
        //        if (DisplayNameCustomer_indb == DisplayNameCustomer)
        //        {
        //            return true; // tk da ton tai
        //        }

        //    }
        //    return false; // tk chua ton tai
        //}
    }
}