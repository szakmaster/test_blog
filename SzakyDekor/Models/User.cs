using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SzakyDekor.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required(ErrorMessage = "User name is required")]
		[MaxLength(100, ErrorMessage = "Max length of user name cannot exceed 100 characters")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		[MaxLength(50)]
		public string EmailAddress { get; set; }

		[Required(ErrorMessage = "Some details of the user is required")]
		[MaxLength(100)]
		public string Details { get; set; }

		[Required]
		public string UserRole { get; set; }
	}
}
