﻿using Infrastructure;
using ViewModels.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

public class HomeController : BaseController
{
	public HomeController() : base()
	{
	}

	[HttpGet]
	public ViewResult Index()
	{
		return View();
	}

	[HttpGet]
	public IActionResult About()
	{
		// **************************************************
		AddPageError(message: null);
		AddPageError(message: string.Empty);
		AddPageError(message: "               ");

		AddPageError(message: "     Page     Error     (1)     ");

		AddPageError(message: "Page Error (2)");
		AddPageError(message: "Page Error (3)");

		AddPageError(message: "Page Error (3)");
		// **************************************************

		// **************************************************
		AddPageWarning(message: null);
		AddPageWarning(message: string.Empty);
		AddPageWarning(message: "               ");

		AddPageWarning(message: "     Page     Warning     (1)     ");

		AddPageWarning(message: "Page Warning (2)");
		AddPageWarning(message: "Page Warning (3)");

		AddPageWarning(message: "Page Warning (3)");
		// **************************************************

		// **************************************************
		AddPageSuccess(message: null);
		AddPageSuccess(message: string.Empty);
		AddPageSuccess(message: "               ");

		AddPageSuccess(message: "     Page     Success     (1)     ");

		AddPageSuccess(message: "Page Success (2)");
		AddPageSuccess(message: "Page Success (3)");

		AddPageSuccess(message: "Page Success (3)");
		// **************************************************

		// **************************************************
		AddToastError(message: null);
		AddToastError(message: string.Empty);
		AddToastError(message: "               ");

		AddToastError(message: "     Toast     Error     (1)     ");

		AddToastError(message: "Toast Error (2)");
		AddToastError(message: "Toast Error (3)");

		AddToastError(message: "Toast Error (3)");
		// **************************************************

		// **************************************************
		AddToastWarning(message: null);
		AddToastWarning(message: string.Empty);
		AddToastWarning(message: "               ");

		AddToastWarning(message: "     Toast     Warning     (1)     ");

		AddToastWarning(message: "Toast Warning (2)");
		AddToastWarning(message: "Toast Warning (3)");

		AddToastWarning(message: "Toast Warning (3)");
		// **************************************************

		// **************************************************
		AddToastSuccess(message: null);
		AddToastSuccess(message: string.Empty);
		AddToastSuccess(message: "               ");

		AddToastSuccess(message: "     Toast     Success     (1)     ");

		AddToastSuccess(message: "Toast Success (2)");
		AddToastSuccess(message: "Toast Success (3)");

		AddToastSuccess(message: "Toast Success (3)");
		// **************************************************

		//return RedirectToAction(actionName: "Contact");
		return RedirectToAction(actionName: nameof(Contact));
	}

	[HttpGet]
	public ViewResult Contact()
	{
		// **************************************************
		AddPageError(message: null);
		AddPageError(message: string.Empty);
		AddPageError(message: "               ");

		AddPageError(message: "     Page     Error     (4)     ");

		AddPageError(message: "Page Error (5)");
		AddPageError(message: "Page Error (6)");
		AddPageError(message: "Page Error (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.PageError, message: "Page Error (7)");
		// **************************************************

		// **************************************************
		AddPageWarning(message: null);
		AddPageWarning(message: string.Empty);
		AddPageWarning(message: "               ");

		AddPageWarning(message: "     Page     Warning     (4)     ");

		AddPageWarning(message: "Page Warning (5)");
		AddPageWarning(message: "Page Warning (6)");
		AddPageWarning(message: "Page Warning (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.PageWarning, message: "Page Warning (7)");
		// **************************************************

		// **************************************************
		AddPageSuccess(message: null);
		AddPageSuccess(message: string.Empty);
		AddPageSuccess(message: "               ");

		AddPageSuccess(message: "     Page     Success     (4)     ");

		AddPageSuccess(message: "Page Success (5)");
		AddPageSuccess(message: "Page Success (6)");
		AddPageSuccess(message: "Page Success (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.PageSuccess, message: "Page Success (7)");
		// **************************************************

		// **************************************************
		AddToastError(message: null);
		AddToastError(message: string.Empty);
		AddToastError(message: "               ");

		AddToastError(message: "     Toast     Error     (4)     ");

		AddToastError(message: "Toast Error (5)");
		AddToastError(message: "Toast Error (6)");
		AddToastError(message: "Toast Error (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.ToastError, message: "Toast Error (7)");
		// **************************************************

		// **************************************************
		AddToastWarning(message: null);
		AddToastWarning(message: string.Empty);
		AddToastWarning(message: "               ");

		AddToastWarning(message: "     Toast     Warning     (4)     ");

		AddToastWarning(message: "Toast Warning (5)");
		AddToastWarning(message: "Toast Warning (6)");
		AddToastWarning(message: "Toast Warning (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.ToastWarning, message: "Toast Warning (7)");
		// **************************************************

		// **************************************************
		AddToastSuccess(message: null);
		AddToastSuccess(message: string.Empty);
		AddToastSuccess(message: "               ");

		AddToastSuccess(message: "     Toast     Success     (4)     ");

		AddToastSuccess(message: "Toast Success (5)");
		AddToastSuccess(message: "Toast Success (6)");
		AddToastSuccess(message: "Toast Success (6)");

		AddMessage(type: Infrastructure.Messages.MessageType.ToastSuccess, message: "Toast Success (7)");
		// **************************************************

		return View();
	}

	[HttpPost]
	public ViewResult Contact(ContactViewModel viewModel)
	{
		if (ModelState.IsValid == false)
		{
			return View();
		}

		return View();
	}
}
