using System.Collections.Generic;
using Animal_Management_System.Dao;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository.Implementation
{
    public class ImplAnimalRepository : IAnimalRepository
    {
        private AnimalDAO animalDAO;

        public ImplAnimalRepository()
        {
            animalDAO = new AnimalDAO();
        }

        public Animal GetAnimalById(int animalId) => animalDAO.GetAnimalById(animalId);

        public List<Animal> GetAllAnimals() => animalDAO.GetAllAnimals();


        public void AddNewAnimal(Animal newAnimal) => animalDAO.AddNewAnimal(newAnimal);

        public void UpdateAnimal(Animal updatedAnimal) => animalDAO.UpdateAnimal(updatedAnimal);

        public void DeleteAnimal(Animal deletedAnimal) => animalDAO.DeleteAnimal(deletedAnimal);

        public IEnumerable<Animal> GetAnimalByName(string AnimalName)
        => animalDAO.GetAnimalByName(AnimalName);

        public List<Animal> GetAllAnimalsByAreaId(int areaId) => animalDAO.GetAllAnimalsByAreaId(areaId);
    }
}