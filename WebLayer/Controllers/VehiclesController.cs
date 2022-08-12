using CoreLayer.DTOs;
using CoreLayer.Models;
using Microsoft.AspNetCore.Mvc;
using WebLayer.Services;

namespace WebLayer.Controllers
{
    //Ip testini Postman üzerinde yaptıktan sonra ayrıca web kısında oluşturulan arayüz
    public class VehiclesController : Controller
    {
        //api constructor için DI tasarımı
        private readonly VehicleApiServices _vehicleApiService;
        public VehiclesController(VehicleApiServices vehicleApiServices)
        {
            _vehicleApiService = vehicleApiServices;
        }
        //bütün arabaları dönen metot
        public async Task<IActionResult> Index()
        {
            return View(await _vehicleApiService.GetCarAllAsync());
        }
        //güncelleme için Id'nin bulunması ve özelliklerinin getirilmesi
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var car = await _vehicleApiService.GetByIdAsync(id);
            return View(car);
        }
        //Update işlemi
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(CarDto carDto)
        {
            await _vehicleApiService.UpdateAsync(carDto);
            return RedirectToAction(nameof(Index));
        }
        //Silme işlemi
        public async Task<IActionResult> Remove(int id)
        {
            await _vehicleApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
