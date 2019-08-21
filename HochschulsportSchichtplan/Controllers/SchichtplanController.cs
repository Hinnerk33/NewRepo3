using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HochschulsportSchichtplan.Models;
using Microsoft.IdentityModel;
using HochschulsportSchichtplan.Data;
using Microsoft.AspNetCore.Authorization;

namespace HochschulsportSchichtplan.Controllers
{
    public class SchichtplanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}