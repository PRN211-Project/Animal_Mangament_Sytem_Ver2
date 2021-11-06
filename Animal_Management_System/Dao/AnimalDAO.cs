using System.Collections.Generic;
using System.Linq;
using Animal_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Management_System.Dao
{
    public class AnimalDAO
    {
        private  Animal_Management_SystemContext _dbContext;

        public AnimalDAO()
        {

        }
        public List<Animal> GetAllAnimalsByAreaId(int areaId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var animal = _dbContext.Animals.Where(a => a.AreaId == areaId).ToList();
                return animal;
            }
        }

        public Animal GetAnimalById(int animalId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var animal = _dbContext.Animals.FirstOrDefault(a => a.Id == animalId);
                return animal;
            }
        }

        public List<Animal> GetAllAnimals()
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var animalList = _dbContext.Animals.ToList();
                return animalList;
            }
        }

        public void AddNewAnimal(Animal newAnimal)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(newAnimal).State = EntityState.Added;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateAnimal(Animal updatedAnimal)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(updatedAnimal).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteAnimal(Animal deleteAnimal)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(deleteAnimal).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Animal> GetAnimalByName(string AnimalName)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                IEnumerable<Animal> result = null;
                IEnumerable<Animal> animalList = null;
                animalList = _dbContext.Animals.AsNoTracking().ToList();

                var animal = from pro in animalList
                    where pro.Name.Contains(AnimalName)
                    select pro;
                result = animal;
                return result;
            }
        }
    }
}