using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniSiparisYonetimi.Models;

namespace MiniSiparisYonetimi.Controllers;

public class HomeController : Controller
{
 

    public string Index()
    {
        return "home/index";
    }

    public string Contact()
    {
        return "home/contact";
    }

}
