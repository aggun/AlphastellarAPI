using CoreLayer.DTOs;
using CoreLayer.Models;
using Microsoft.AspNetCore.Mvc;
using WebLayer.Services;

namespace WebLayer.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly VehicleApiServices _vehicleApiService;
        public VehiclesController(VehicleApiServices vehicleApiServices)
        {
            _vehicleApiService = vehicleApiServices;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _vehicleApiService.GetCarAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var car = await _vehicleApiService.GetByIdAsync(id);
            return View(car);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(CarDto carDto)
        {
            await _vehicleApiService.UpdateAsync(carDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            await _vehicleApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
