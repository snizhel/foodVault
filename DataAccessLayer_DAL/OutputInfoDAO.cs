using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class OutputInfoDAO : GeneralDAO
    {
        public DataSet getAllOutputInfo()
        {
            return getAll("OutputInfo");
        }


        //public DataSet searchByName(string name)
        //{
        //    return search("Input", "DisplayNameCustomer like '%" + name + "%' or " +
        //                              "DisplayNameCustomer like '%" + name + "%' ");
        //}
        public DataSet searchByCustomerId(int id)
        {
            return search("OutputInfo", "IdCustomer like '%" + id + "%' or " +
                                      "IdCustomer like '%" + id + "%' ");
        }

        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("OutputInfo", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteOutputInfo(int id)
        {
            try
            {
                string sql = "delete [OutputInfo] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateOutputInfo(OutputInfo outputInfo)
        {
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + outputInfo.FirstName +
            //                 "' , Address='" + outputInfo.Address + "',Bdate='" +
            //                 outputInfo.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + outputInfo.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 outputInfo.FirstName, outputInfo.Address, outputInfo.Dob.ToString("yyyy/MM/dd"), outputInfo.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }


        public int createOutputInfo(OutputInfo outputInfo)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               outputInfo.FirstName, outputInfo.Ssn, outputInfo.Dob.ToString("yyyy/MM/dd"), outputInfo.Address);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }
    }
}
