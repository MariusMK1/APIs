using Microsoft.EntityFrameworkCore;
using PointsAPI.Data;
using PointsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Repositories
{
    public class PointRepository
    {
        private readonly DataContext _dataContext;

        public PointRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<PointEntity>> GetAll()
        {
            return await _dataContext.Point.ToListAsync();
        }
        public async Task<PointEntity> GetById(int id)
        {
            PointEntity point = await _dataContext.Point.FirstOrDefaultAsync(si => si.Id == id);
            if (point == null)
            {
                throw new ArgumentException("Point is not found");
            }
            return point;
        }
        public async Task Create(PointEntity point)
        {
            _dataContext.Point.Add(point);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Update(PointEntity point)
        {
            _dataContext.Update(point);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Remove(int id)
        {
            PointEntity point = await GetById(id);
            _dataContext.Point.Remove(point);
            await _dataContext.SaveChangesAsync();
        }
    }
}
