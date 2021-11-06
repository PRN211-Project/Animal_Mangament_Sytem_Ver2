using System.Collections.Generic;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository
{
    public interface IAnimalRepository
    {
        Animal GetAnimalById(int animalId);

        List<Animal> GetAllAnimals();

        void AddNewAnimal(Animal newAnimal);

        void UpdateAnimal(Animal updatedAnimal);

        void DeleteAnimal(Animal deletedAnimal);
        public IEnumerable<Animal> GetAnimalByName(string AnimalName);

        List<Animal> GetAllAnimalsByAreaId(int areaId);
    }
}