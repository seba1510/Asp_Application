using Asp_Project.DataBase;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Project.ViewComponents
{
	public class LatestItem : Microsoft.AspNetCore.Mvc.ViewComponent
	{
        private readonly ExchangesDbContext _dbContext;
        public LatestItem(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items
            .OrderByDescending(x => x.Id).FirstOrDefault();
            return View("Index", latestItem);
        }
    }
}

