
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class FoodDAO : GeneralDAO
    {
        public List<Food> getAllFoods()
        {
            List<Food> lst = new List<Food>();

            DataSet ds = getAll("Food");
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Food acc = new Food()
                {
                    FoodId = int.Parse(dr["FoodId"].ToString()),
                    DisplayNameFood = dr["DisplayNameFood"].ToString()
                };
                lst.Add(acc);
            }

            return lst;

        }
        public DataSet getAllFood()
        {
            return getAll("Food");
        }
        public DataSet searchByName(string name)
        {
            return search("Food", "DisplayName like '%" + name + "%' or " +
                                      "DisplayName like '%" + name + "%' ");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Food", " FoodId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteFood(string id)
        {
            try
            {
                string sql = "delete [Food] where FoodId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        public int updateFood(Food food)
        {
            try
            {
                string sql = "update [Food] set DisplayNameFood = '" + food.DisplayNameFood + "', " +
                                                 "Quantity = '" + food.Quantity + "', " +
                                                 "Image = '" + food.Image + "', " +
                                                 "IdSuplier = '" + food.IDSuplier + "', " +
                                                 "DateOfManufacture = '" + food.StartDate.ToString("MM/dd/yyyy") + "', " +
                                                 "ExpirationDate = '" + food.EndDate.ToString("MM/dd/yyyy") + "' " +
                                                 "where FoodId = '" + food.FoodId + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        public int createFood(Food food)
        {
            try
            {
                string sql = "insert into [Food] (DisplayNameFood,Quantity,Image,IdSuplier,DateOfManufacture,ExpirationDate)" +
                    "values ('" + food.DisplayNameFood + "','" + food.Quantity + "','" + food.Image + "','" + food.IDSuplier + "','" + food.StartDate.ToString("MM/dd/yyyy") + "','" + food.EndDate.ToString("MM/dd/yyyy") + "')";
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
