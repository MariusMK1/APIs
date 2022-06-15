using Microsoft.EntityFrameworkCore;
using PointsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<PointEntity> Point { get; set; }
        public DbSet<PointsList> PointsLists { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
