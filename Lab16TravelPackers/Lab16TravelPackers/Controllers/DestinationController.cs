﻿using Lab16TravelPackers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16TravelPackers.Controllers
{
    public class DestinationController : Controller
    {
        
        private readonly IDestinationRepository _repository;

        public DestinationController(IDestinationRepository repo)
        {
            _repository = repo;
        }
        public ViewResult Index()
        {
            return View(_repository.Destination);
        }
    }
}