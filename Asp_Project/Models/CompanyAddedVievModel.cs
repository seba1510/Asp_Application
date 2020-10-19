using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Project.Models
{
	public class CompanyAddedVievModel
	{
		public int NumberOfCharsInName { get; set; }

		public int NumberOfCharsInDescription { get; set; }
		public bool	IsHidden { get; set; }
	}
}
