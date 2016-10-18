﻿using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WS_Hotline.ServicesWeb.Models;

namespace WS_Hotline.ServicesWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}