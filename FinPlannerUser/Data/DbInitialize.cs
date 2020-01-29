using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPlannerUser.Models;
namespace FinPlannerUser.Data
{
	public class DbInitialize
	{
		public static void Initialize(UserModelContext context)
		{
			context.Database.EnsureCreated();
			if(context.UserModels.Any())
			{
				return;
			}
			context.SaveChanges();
		}
	}
}
