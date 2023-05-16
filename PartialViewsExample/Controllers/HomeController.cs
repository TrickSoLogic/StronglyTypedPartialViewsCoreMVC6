﻿using Microsoft.AspNetCore.Mvc;

namespace StronglyTypedPartialViewsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public IActionResult Index()
    {
      return View();
    }

    [Route("about")]
    public IActionResult About()
    {
      return View();
    }
  }
}
