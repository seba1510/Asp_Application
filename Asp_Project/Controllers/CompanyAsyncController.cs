using Asp_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Project.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanyAsyncController : ControllerBase
	{
        [HttpPost]
        [Route("AddNewItem")]
        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var companyAddedModel = new CompanyAddedVievModel
            {
                NumberOfCharsInName = companyModel.Name.Length,
                NumberOfCharsInDescription = companyModel.Description.Length,
                IsHidden = !companyModel.IsVisible
            };

            return Ok(companyAddedModel);
        }
    }
}
