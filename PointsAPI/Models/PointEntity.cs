using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Models
{
    public class PointEntity
    {
        public int Id  { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? PointsListId { get; set; }
    }
}
