﻿using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Bill()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetAll");
            return View(result);
        }
        public async Task<IActionResult> UpdateBillStatus(Guid id)
        {
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{id}");
            b.BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{id}", b);
            return RedirectToAction("Bill");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Bill/Delete/{id}");
            return RedirectToAction("Bill");
        }
    }
}