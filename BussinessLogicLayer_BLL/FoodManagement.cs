using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer_DAL;

namespace BussinessLogicLayer_BLL
{
    public class FoodManagement
    {
        FoodDAO foodDAO = new FoodDAO();
        //admin
        public DataSet ViewFoods()
        {
            return foodDAO.getAllFood();
        }


        public DataSet searchByName(string name)
        {
            return foodDAO.searchByName(name);
        }

        public DataSet listFoodById(int id)
        {
            return foodDAO.searchBySuplierId(id);
        }


        public SqlDataReader getDatails(string id)
        {
            return foodDAO.findById(id);
        }


        public void closeConnection()
        {
            foodDAO.closeConnection();
        }


        //public int AddEmployee(Food emp)
        //{
        //    // check valid

        //    //call DAO
        //    return foodDAO.createFood(emp);

        //}
        //public int UpdateEmployee(Food emp)
        //{
        //    // check valid

        //    //call DAO
        //    return foodDAO.createFood(emp);

        //}
        public int RemoveFood(string id)
        {
            // check valid

            //call DAO
            return foodDAO.deleteFood(id);

        }
        public bool isExistIdFood(string idFood)
        {
            List<Food> lst = foodDAO.getAllFoods();
            foreach (Food acc in lst)
            {
                string idFood_indb = acc.FoodId;
                if (idFood_indb == idFood)
                {
                    return true; // tk da ton tai
                }

            }
            return false; // tk chua ton tai
        }
        public bool isExistDisplayNameFood(string DisplayNameFood)
        {
            List<Food> lst = foodDAO.getAllFoods();
            foreach (Food acc in lst)
            {
                string DisplayNameFood_indb = acc.DisplayNameFood;
                if (DisplayNameFood_indb == DisplayNameFood)
                {
                    return true; // tk da ton tai
                }

            }
            return false; // tk chua ton tai
        }
    }
}
