using System.ComponentModel.DataAnnotations;

namespace ViewModels.Pages;

public class ContactViewModel : object
{
	public ContactViewModel() : base()
	{
	}

	[Display(Name = "Full Name")]
	[StringLength(maximumLength: 50)]
	[Required(AllowEmptyStrings = false)]
	public string? FullName { get; set; }

	[Display(Name = "Subject")]
	[StringLength(maximumLength: 100)]
	[Required(AllowEmptyStrings = false)]
	public string? Subject { get; set; }

	[Display(Name = "Body")]
	[StringLength(maximumLength: 1000)]
	[Required(AllowEmptyStrings = false)]
	[DataType(dataType: DataType.MultilineText)]
	public string? Body { get; set; }
}
