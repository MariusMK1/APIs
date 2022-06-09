using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.Models;
using TodoAPI.Services;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public List<Todo> GetAll()
        {
            return _todoService.GetAll();
        }
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return _todoService.Get(id);
        }
        [HttpPost]
        public void Create(string name)
        {
            _todoService.Add(name);
        }
        [HttpPut]
        public void Update(Todo todo)
        {
            _todoService.Update(todo);
        }
        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            _todoService.Remove(id);
        }
    }
}
