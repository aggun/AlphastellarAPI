using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using CoreLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Car> _carService;
        private readonly IService<Bus> _busService;
        private readonly IService<Boat> _boatService;

        public VehicleController(IMapper mapper, IService<Car> carService, IService<Bus> busService , IService<Boat> boatService )
        {
            _mapper = mapper;
            _carService = carService;
            _busService = busService;
            _boatService = boatService;
        }
        [HttpGet("GetCarByColor/{id}")]
        public IActionResult GetCarByColor(int id)
        {
            var cars = _carService.Where(x => x.ColorId == id);
            var carsDtos = _mapper.Map<List<CarDto>>(cars.ToList());
            return Ok(carsDtos);
        }
        [HttpGet("GetBusByColor/{id}")]
        public IActionResult GetBusByColor(int id)
        {
            var buses = _busService.Where(x => x.ColorId == id);
            var busesDtos = _mapper.Map<List<BusDto>>(buses.ToList());
            return Ok(busesDtos);
        }
        [HttpGet("GetBoatByColor/{id}")]
        public IActionResult GetBoatByColor(int id)
        {
            var boats = _boatService.Where(x => x.ColorId == id);
            var boatsDtos = _mapper.Map<List<BoatDto>>(boats.ToList());
            return Ok(boatsDtos);
        }
        [HttpPut]
        public async Task<IActionResult> Update(CarUpdateDto carUpdateDto)
        {
            await _carService.UpdateAsync(_mapper.Map<Car>(carUpdateDto));
            return Ok(204);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            await _carService.RemoveAsync(car);
            return Ok(204);
        }
    }
}
