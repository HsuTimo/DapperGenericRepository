using DapperRepositoryLib.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class PersonController : Controller
    {
        private readonly IRepository _repository;
        public PersonController(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _repository.GetAllAsync<Person>();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            await _repository.CreateAsync<Person>(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var person = await _repository.GetByIdAsync<Person>(id);
            return View(person);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Person newPerson)
        {
            await _repository.UpdateAsync<Person>(newPerson);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var person = await _repository.GetByIdAsync<Person>(id);
            return View(person);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Person toDeletePerson)
        {
            await _repository.DeleteAsync<Person>(toDeletePerson);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var person = await _repository.GetByIdAsync<Person>(id);
            return View(person);
        }
    }
}
