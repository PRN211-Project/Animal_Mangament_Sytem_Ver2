using System.Collections.Generic;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository
{
    public interface IAreaRepository
    {
        Area GetAreaById(int areaId);

        List<Area> GetAllAreas();

        void AddNewArea(Area newArea);

        void UpdateArea(Area updatedArea);

        void DeleteArea(Area deletedArea);
    }
}