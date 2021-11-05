using System.Collections.Generic;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository
{
    public interface ITypeRepository
    {
        List<Type> GetAllTypes();

        Type GetTypeById(int typeId);
    }
}