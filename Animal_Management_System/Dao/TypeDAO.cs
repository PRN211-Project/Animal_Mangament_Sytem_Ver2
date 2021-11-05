using System.Collections.Generic;
using System.Linq;
using Animal_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Management_System.Dao
{
    public class TypeDAO
    {
        private Animal_Management_SystemContext _dbContext;

        public List<Type> GetAllTypes()
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var typeList = _dbContext.Types.AsNoTracking().ToList();
                return typeList;
            }
        }

        public Type GetTypeById(int typeId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var type = _dbContext.Types.AsNoTracking().FirstOrDefault(t => t.Id == typeId);
                return type;
            }
        }
    }
}