using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Models
{
    public class PointsList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PointEntity> Points { get; set; }
    }
}
