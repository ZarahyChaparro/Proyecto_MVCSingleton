using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSingleton.Models;

public class HomeController : Controller
{
    private readonly Singleton _singleton;

    public HomeController()
    {
        _singleton = Singleton.Instance;
    }

    public ActionResult Index()
    {
        ViewBag.Message = _singleton.GetMessage();
        return View();
    }

    [HttpPost]
    public ActionResult Sumar(int num1, int num2)
    {
        int resultado = _singleton.Sumar(num1, num2);
        return Json(resultado);
    }
}
