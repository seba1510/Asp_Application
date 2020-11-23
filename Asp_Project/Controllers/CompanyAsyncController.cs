using Asp_Project.DataBase;
using Asp_Project.Entities;
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
        private readonly ExchangesDbContext _dbcontext;
        public CompanyAsyncController(ExchangesDbContext context)
        {
            _dbcontext = context;
        }


        [HttpPost]
        [Route("AddNewItem")]

        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var entity = new ItemEntity
            {
                Name = companyModel.Name,
                Description = companyModel.Description,
                IsVisible = companyModel.IsVisible,
            };

            _dbcontext.Items.Add(entity);
            _dbcontext.SaveChanges();
            return Ok();
        }

        public async Task<IActionResult> GetItemsBack()
        {
            var items = _dbcontext.Items.ToList();

            return Ok(items);
        }
    }
}
