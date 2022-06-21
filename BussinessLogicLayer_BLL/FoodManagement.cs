using DataAccessLayer_DAL;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        public int RemoveEmployee(string id)
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
                string idFood_indb = acc.FoodId.ToString();
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
        public int AddFood(Food food)
        {
            return foodDAO.createFood(food);
        }
        public int UpdateFood(Food food)
        {
            return foodDAO.updateFood(food);
        }
        public int RemoveFood(int id)
        {
            return foodDAO.deleteFood(id.ToString());
        }

    }
}
