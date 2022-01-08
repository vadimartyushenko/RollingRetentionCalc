using System;

namespace Models
{
	public class User
	{
		public decimal UserId { get; set; }

		public DateTime RegistrationDate { get; set; }

		public DateTime LastActivityDate { get; set; }

        public User () { }
        public User(decimal id, DateTime regDate, DateTime actDate)
        {
            UserId = id;
            RegistrationDate = regDate;
			LastActivityDate = actDate;
        }

        public User(decimal id) : this(id, DateTime.Now, DateTime.Now) { }

    }
}
