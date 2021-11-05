using System.Collections.Generic;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository
{
    public interface IFoodRepository
    {
        Food GetFoodById(int id);

        List<Food> GetAllFoods();

        void AddNewFood(Food newFood);

        void UpdateFood(Food updatedFood);

        void DeleteFood(Food deletedFood);
    }
}