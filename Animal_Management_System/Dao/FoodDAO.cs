using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Animal_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Management_System.Dao
{
    public class FoodDAO
    {
        private Animal_Management_SystemContext _dbContext;

        public Food GetFoodById(int foodId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var food = _dbContext.Foods.AsNoTracking().FirstOrDefault( s => s.Id == foodId);
                return food;
            }
        }

        public List<Food> GetAllFood()
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var foodList = _dbContext.Foods.AsNoTracking().ToList();
                return foodList;
            }
        }

        public void AddNewFood(Food newFood)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(newFood).State = EntityState.Added;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateFood(Food updatedFood)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(updatedFood).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteFood(Food deletedFood)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(deletedFood).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }
    }
}