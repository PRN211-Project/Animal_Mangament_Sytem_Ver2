using System.Collections.Generic;
using Animal_Management_System.Dao;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository.Implementation
{
    public class ImplAreaRepository : IAreaRepository

    {
        private AreaDAO areaDao;

        public ImplAreaRepository()
        {
            areaDao = new AreaDAO();
        }

        public Area GetAreaById(int areaId) => areaDao.GetAreaById(areaId);


        public List<Area> GetAllAreas() => areaDao.GetAllAreas();


        public void AddNewArea(Area newArea) => areaDao.AddNewArea(newArea);

        public void UpdateArea(Area updatedArea) => areaDao.UpdateArea(updatedArea);

        public void DeleteArea(Area deletedArea) => areaDao.DeleteArea(deletedArea);
    }
}