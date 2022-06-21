using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer_BLL
{
    public class SupilerManagement
    {

        SuplierDAO suplierDao = new SuplierDAO();

        public DataSet ViewSupilers()
        {
            return suplierDao.getAllSuplier();
        }

        public SqlDataReader getDatails(string id)
        {
            return suplierDao.findById(id);
        }

        public int AddSuplier(Suplier suplier)
        {
            // check valid

            //call DAO
            return suplierDao.createSuplier(suplier);
        }

        public int UpdateSuplier(Suplier suplier)
        {
            // check valid

            //call DAO
            return suplierDao.updateSuplier(suplier);
        }

        public int DeleteSuplier(int id)
        {
            // check valid

            //call DAO
            return suplierDao.deleteSuplier(id);
        }


        public void closeConnection()
        {
            suplierDao.closeConnection();
        }

    }
}
