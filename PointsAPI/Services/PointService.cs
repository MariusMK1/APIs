using AutoMapper;
using PointsAPI.Dtos;
using PointsAPI.Models;
using PointsAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Services
{
    public class PointService
    {
        private readonly PointRepository _pointRepository;
        private readonly IMapper _mapper;

        public PointService(PointRepository pointRepository, IMapper mapper)
        {
            _pointRepository = pointRepository;
            _mapper = mapper;
        }

        public async Task<List<PointDto>> GetAll()
        {
            List<PointEntity> points = await _pointRepository.GetAll();
            List<PointDto> dtos = _mapper.Map<List<PointDto>>(points);
            return dtos;
        }
        public async Task<PointDto> GetById(int id)
        {
            PointEntity point = await _pointRepository.GetById(id);
            PointDto dto = _mapper.Map<PointDto>(point);
            return dto;
        }
        public async Task Create(PointDto point)
        {
            PointEntity entity = new PointEntity
            {
                X = point.X,
                Y = point.Y,
            };
            await _pointRepository.Create(entity);
        }
        public async Task Update(PointDto pointDto)
        {
            PointEntity point = await _pointRepository.GetById(pointDto.Id);
            await _pointRepository.Update(point);
        }
        public async Task Remove(int id)
        {
            await _pointRepository.Remove(id);
        }
    }
}
