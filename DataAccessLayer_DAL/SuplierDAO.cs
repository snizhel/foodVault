using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class SuplierDAO : GeneralDAO
    {
        public DataSet getAllSuplier()
        {
            return getAll("Suplier");
        }


        public DataSet searchByName(string name)
        {
            return search("Suplier", "DisplayName like '%" + name + "%' or " +
                                      "DisplayName like '%" + name + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Suplier", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteSuplier(int id)
        {
            try
            {
                string sql = "delete [Suplier] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateSuplier(Suplier suplier)
        {
            try
            {
                string sql = "update [Suplier] set DisplayName = '" + suplier.DisplayName + "', " +
                                                 "Address = '" + suplier.Address + "', " +
                                                 "Phone = '" + suplier.Phone + "', " +
                                                 "Email = '" + suplier.Email + "', " +
                                                 "ContractDate = '" + suplier.ContractDate + "' " +
                                                 "where Id = '" + suplier.Id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createSuplier(Suplier suplier)
        {
            try
            {
                string sql = "insert into [Suplier] (DisplayName, Address, Phone, Email, MoreInfo, ContractDate) " +
                             "values ('" + suplier.DisplayName + "', '" + suplier.Address + "', '" + suplier.Phone + "', '" + suplier.Email + "', '" + suplier.MoreInfo + "', '" + suplier.ContractDate.ToString("MM/dd/yyyy") + "')";
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
