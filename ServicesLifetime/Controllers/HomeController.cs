﻿using Microsoft.AspNetCore.Mvc;
using ServicesLifetime.Interfaces;

namespace ServicesLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scoped;
        private readonly ITransientService _transient;

        public HomeController(ISingletonService singleton, IScopedService scoped, ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }
  
        public IActionResult Index()
        {
            return View("Index", _singleton.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.GetGuid());
        }
    }
}
