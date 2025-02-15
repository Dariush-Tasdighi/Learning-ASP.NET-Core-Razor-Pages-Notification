using System.ComponentModel.DataAnnotations;

namespace ViewModels.Views.Home
{
	public class ContactViewModel : object
	{
		public ContactViewModel() : base()
		{
		}

		// **********
		[Display(Name = "Full Name")]

		[Required(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[StringLength(maximumLength: 50,
			ErrorMessage = "The maximum length of {0} is {1}!")]
		public string? FullName { get; set; }
		// **********

		// **********
		[Display(Name = "Subject")]

		[Required(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[StringLength(maximumLength: 100,
			ErrorMessage = "The maximum length of {0} is {1}!")]
		public string? Subject { get; set; }
		// **********

		// **********
		[Display(Name = "Body")]

		[Required(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[StringLength(maximumLength: 1000,
			ErrorMessage = "The maximum length of {0} is {1}!")]

		[DataType(dataType: DataType.MultilineText)]
		public string? Body { get; set; }
		// **********
	}
}
