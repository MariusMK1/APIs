using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.Data;
using TodoAPI.Models;
using TodoAPI.Repositories;

namespace TodoAPI.Services
{
    public class TodoService
    {
        private readonly TodoRepository _todoRepository;
        public TodoService(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<Todo>> GetAll()
        {
            List<Todo> todos = await _todoRepository.GetAll();
            return todos;
        }
        public async Task<Todo> GetById(int id)
        {
            Todo todo = await _todoRepository.GetById(id);
            return todo;
        }
        public async Task Create(string name)
        {
            await _todoRepository.Crate(name);
        }
        public async Task Update(Todo todo)
        {
            await _todoRepository.Update(todo);
        }
        public async Task Remove(int id)
        {
            await _todoRepository.Remove(id);
        }
    }
}
