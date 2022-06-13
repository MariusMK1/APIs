using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.Dtos
{
    public class CreatedTodoDto
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
    }
}
