using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinPlannerUser.Models
{
	public class UserModel
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		public string EmailAddress { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public bool isActive { get; set; }
		[Required]
		public bool isAlive { get; set; }
	}
}
