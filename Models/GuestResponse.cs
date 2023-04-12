using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage ="Please you should add you name ..")]
		public string? Name  { get; set; }

		[Required(ErrorMessage ="Please you should add you email ..")]
		[EmailAddress]
		public string? Email {get; set;}

		[Required(ErrorMessage ="Please you should add you phone number ..")]
		public string? Phone {get; set;}

		[Required(ErrorMessage ="Please say weather you will attend or not...")]
		public bool? WillAttend {get; set;}
	}
}
