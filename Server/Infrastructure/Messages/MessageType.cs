namespace Infrastructure.Messages;

public enum MessageType : byte
{
	PageError = 10,
	PageWarning = 11,
	PageSuccess = 12,

	ToastError = 20,
	ToastWarning = 21,
	ToastSuccess = 22,
}
