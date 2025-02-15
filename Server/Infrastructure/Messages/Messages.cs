using System.Collections.Generic;

namespace Infrastructure.Messages;

public class Messages : object
{
	public enum MessageType
	{
		PageError,
		PageWarning,
		PageSuccess,

		ToastError,
		ToastWarning,
		ToastSuccess,
	}

	public static readonly string KeyName = "Messages";

	public static string? FixText(string? text)
	{
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return null;
		}

		text = text.Trim();

		while (text.Contains(value: "  "))
		{
			text = text.Replace(oldValue: "  ", newValue: " ");
		}

		return text;
	}

	public Messages() : base()
	{
		_pageErrors = [];
		_pageWarnings = [];
		_pageSuccesses = [];

		_toastErrors = [];
		_toastWarnings = [];
		_toastSuccesses = [];
	}

	//public List<string> PageErrors { get; set; } = [];
	//public List<string> PageErrors { get; init; } = [];
	//private readonly List<string> _pageErrors = [];
	//public List<string> PageErrors
	//{
	//	get
	//	{
	//		return _pageErrors;
	//	}
	//}

	//[Newtonsoft.Json.JsonProperty]
	private readonly List<string> _pageErrors = [];

	//[Newtonsoft.Json.JsonIgnore]
	public IReadOnlyList<string> PageErrors
	{
		get
		{
			return _pageErrors;
		}
	}

	private readonly List<string> _pageWarnings;

	public IReadOnlyList<string> PageWarnings
	{
		get
		{
			return _pageWarnings;
		}
	}

	private readonly List<string> _pageSuccesses;

	public IReadOnlyList<string> PageSuccesses
	{
		get
		{
			return _pageSuccesses;
		}
	}

	public bool HasAnyPageMessages
	{
		get
		{
			if ((_pageErrors is null || _pageErrors.Count == 0) &&
				(_pageWarnings is null || _pageWarnings.Count == 0) &&
				(_pageSuccesses is null || _pageSuccesses.Count == 0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}

	private readonly List<string> _toastErrors;

	public IReadOnlyList<string> ToastErrors
	{
		get
		{
			return _toastErrors;
		}
	}

	private readonly List<string> _toastWarnings;

	public IReadOnlyList<string> ToastWarnings
	{
		get
		{
			return _toastWarnings;
		}
	}

	private readonly List<string> _toastSuccesses;

	public IReadOnlyList<string> ToastSuccesses
	{
		get
		{
			return _toastSuccesses;
		}
	}

	public bool HasAnyToastMessages
	{
		get
		{
			if ((_toastErrors is null || _toastErrors.Count == 0) &&
				(_toastWarnings is null || _toastWarnings.Count == 0) &&
				(_toastSuccesses is null || _toastSuccesses.Count == 0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}

	public bool AddPageError(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_pageErrors.Contains(item: message))
		{
			return false;
		}

		_pageErrors.Add(item: message);

		return true;
	}

	public bool AddPageWarning(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_pageWarnings.Contains(item: message))
		{
			return false;
		}

		_pageWarnings.Add(item: message);

		return true;
	}

	public bool AddPageSuccess(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_pageSuccesses.Contains(item: message))
		{
			return false;
		}

		_pageSuccesses.Add(item: message);

		return true;
	}

	public bool AddToastError(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_toastErrors.Contains(item: message))
		{
			return false;
		}

		_toastErrors.Add(item: message);

		return true;
	}

	public bool AddToastWarning(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_toastWarnings.Contains(item: message))
		{
			return false;
		}

		_toastWarnings.Add(item: message);

		return true;
	}

	public bool AddToastSuccess(string? message)
	{
		message = FixText(text: message);

		if (message is null)
		{
			return false;
		}

		if (_toastSuccesses.Contains(item: message))
		{
			return false;
		}

		_toastSuccesses.Add(item: message);

		return true;
	}

	public bool AddMessage(MessageType type, string? message)
	{
		switch (type)
		{
			case MessageType.PageError:
			{
				return AddPageError(message: message);
			}

			case MessageType.PageWarning:
			{
				return AddPageWarning(message: message);
			}

			case MessageType.PageSuccess:
			{
				return AddPageSuccess(message: message);
			}

			case MessageType.ToastError:
			{
				return AddToastError(message: message);
			}

			case MessageType.ToastWarning:
			{
				return AddToastWarning(message: message);
			}

			case MessageType.ToastSuccess:
			{
				return AddToastSuccess(message: message);
			}

			default:
			{
				return false;
			}
		}
	}

	public void ClearPageErrors()
	{
		_pageErrors.Clear();
	}

	public void ClearPageWarnings()
	{
		_pageWarnings.Clear();
	}

	public void ClearPageSuccesses()
	{
		_pageSuccesses.Clear();
	}

	public void ClearPageMessages()
	{
		ClearPageErrors();
		ClearPageWarnings();
		ClearPageSuccesses();
	}

	public void ClearToastErrors()
	{
		_toastErrors.Clear();
	}

	public void ClearToastWarnings()
	{
		_toastWarnings.Clear();
	}

	public void ClearToastSuccesses()
	{
		_toastSuccesses.Clear();
	}

	public void ClearToastMessages()
	{
		ClearToastErrors();
		ClearToastWarnings();
		ClearToastSuccesses();
	}
}
