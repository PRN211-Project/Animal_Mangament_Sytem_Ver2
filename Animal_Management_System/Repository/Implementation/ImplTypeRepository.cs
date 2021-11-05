using System.Collections.Generic;
using Animal_Management_System.Dao;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository.Implementation
{
    public class ImplTypeRepository : ITypeRepository
    {
        private TypeDAO typeDao;

        public ImplTypeRepository()
        {
            typeDao = new TypeDAO();
        }

        public List<Type> GetAllTypes() => typeDao.GetAllTypes();

        public Type GetTypeById(int typeId) => typeDao.GetTypeById(typeId);

    }
}