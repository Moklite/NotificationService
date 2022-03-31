using Microsoft.AspNetCore.Mvc;
using NotificationService.Contracts;
using NotificationService.Entities;
using NotificationService.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Web.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplication _repository;


		public ApplicationController(IApplication repository)
		{
			_repository = repository;
		}

        
    }
}
