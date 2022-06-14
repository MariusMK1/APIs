using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.Data;
using TodoAPI.Dtos;
using TodoAPI.Models;
using TodoAPI.Repositories;

namespace TodoAPI.Services
{
    public class TodoService
    {
        private readonly TodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodoService(TodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<List<TodoDto>> GetAll()
        {
            List<Todo> todos = await _todoRepository.GetAll();
            List<TodoDto> dtos = _mapper.Map<List<TodoDto>>(todos);
            return dtos;
        }
        public async Task<TodoDto> GetById(int id)
        {
            Todo todo = await _todoRepository.GetById(id);
            TodoDto dto = _mapper.Map<TodoDto>(todo);
            return dto;
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
