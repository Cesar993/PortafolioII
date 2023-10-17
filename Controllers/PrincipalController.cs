
// indicamos que utilizaremos aspnetcore y mvc
using Microsoft.AspNetCore.Mvc;

namespace ProyectoPelis.controller;


public class PrincipalController : Controller{



//agregamos las rutas de esta forma
    [HttpGet]
    [Route("")]
    public ViewResult Index(){

        return View("Index");
    }

    [HttpGet]
    [Route("Projects")]
    public ViewResult Project(){

        return View("Projects");
    }
    [HttpGet]
    [Route("Contact")]
    public ViewResult Contact(){

        return View("Contact");
    }






}