using System;

namespace Models
{
	public class User
	{
		public decimal UserId { get; set; }

		public DateTime RegistrationData { get; set; }

		public DateTime LastActivityDate { get; set; }
	}
}
