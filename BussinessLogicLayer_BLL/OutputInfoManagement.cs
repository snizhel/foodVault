using DataAccessLayer_DAL;
using System.Data;

namespace BussinessLogicLayer_BLL
{
    public class OutputInfoManagement
    {
        OutputInfoDAO outputInfoDAO = new OutputInfoDAO();
        public DataSet listOutputInfoById(int id)
        {
            return outputInfoDAO.searchByCustomerId(id);
        }
        public DataSet ViewOutputInfo()
        {
            return outputInfoDAO.getAllOutputInfo();
        }
        public int RemoveOutputInfo(int id)
        {
            // check valid

            //call DAO
            return outputInfoDAO.deleteOutputInfo(id);

        }
    }
}
