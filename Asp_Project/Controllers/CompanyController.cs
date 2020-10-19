﻿using Asp_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Project.Controllers
{
	public class CompanyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(CompanyModel company)
		{
			var vievModel = new CompanyAddedVievModel
			{
				NumberOfCharsInName = company.Name.Length,
				NumberOfCharsInDescription = company.Description.Length,
				IsHidden = !company.IsVisible
			};

			return View("CompanyAdded", vievModel);
		}
	}
}
