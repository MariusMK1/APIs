using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.Data;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public class TodoService
    {
        private readonly DataContext _dataContext;

        public TodoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Todo> GetAll()
        {
            return _dataContext.Todo.ToList();
        }
        public Todo Get(int id)
        {
            return _dataContext.Todo.FirstOrDefault(x => x.Id == id);
        }
        public void Add(string name)
        {
            Todo todo = new Todo{
                Name = name,
                CreatedDate = DateTime.Now,
            };
            _dataContext.Todo.Add(todo);
            _dataContext.SaveChanges();
        }
        public void Update(Todo todo)
        {
            _dataContext.Update(todo);
            _dataContext.SaveChanges();
        }
        public void Remove(int id)
        {
            var todo = Get(id);
            _dataContext.Todo.Remove(todo);
            _dataContext.SaveChanges();
        }
    }
}
