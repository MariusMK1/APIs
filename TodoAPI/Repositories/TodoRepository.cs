using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.Data;
using TodoAPI.Models;

namespace TodoAPI.Repositories
{
    public class TodoRepository
    {
        private readonly DataContext _dataContext;
        public TodoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Todo>> GetAll()
        {
            return await _dataContext.Todo.ToListAsync();
        }
        public async Task<Todo> GetById(int id)
        {
            Todo todo = await _dataContext.Todo.FirstOrDefaultAsync(si => si.Id == id);
            if (todo == null)
            {
                throw new ArgumentException("Todo is not found");
            }
            return todo;
        }
        public async Task Crate(string name)
        {
            Todo todo = new Todo
            {
                Name = name,
                CreatedDate = DateTime.Now,
            };
            _dataContext.Todo.Add(todo);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Update(Todo todo)
        {
            _dataContext.Update(todo);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Remove(int id)
        {
            Todo todo = await GetById(id);
            _dataContext.Todo.Remove(todo);
            await _dataContext.SaveChangesAsync();
        }
    }
}
