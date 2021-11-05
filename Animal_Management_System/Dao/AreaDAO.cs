using System.Collections.Generic;
using System.Linq;
using Animal_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Management_System.Dao
{
    public class AreaDAO
    {
        private Animal_Management_SystemContext _dbContext;

        public Area GetAreaById(int areaId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var area = _dbContext.Areas.AsNoTracking().Where(a => a.AreaId == areaId).Include(a => a.Animals).FirstOrDefault();
                return area;
            }
        }

        public List<Area> GetAllAreas()
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                var areaList = _dbContext.Areas.AsNoTracking().ToList();
                return areaList;
            }
        }

        public void AddNewArea(Area newArea)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(newArea).State = EntityState.Added;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateArea(Area updatedArea)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(updatedArea).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteArea(Area deletedArea)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(deletedArea).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }
    }
}