using System.Collections.Generic;
using Animal_Management_System.Dao;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository.Implementation
{
    public class ImplFoodRepository : IFoodRepository
    {
        private FoodDAO foodDAO;

        public ImplFoodRepository()
        {
            foodDAO = new FoodDAO();
        }

        public Food GetFoodById(int id) => foodDAO.GetFoodById(id);

        public List<Food> GetAllFoods() => foodDAO.GetAllFood();

        public void AddNewFood(Food newFood) => foodDAO.AddNewFood(newFood);

        public void UpdateFood(Food updatedFood) => foodDAO.UpdateFood(updatedFood);
        public void DeleteFood(Food deletedFood) => foodDAO.DeleteFood(deletedFood);
    }
}