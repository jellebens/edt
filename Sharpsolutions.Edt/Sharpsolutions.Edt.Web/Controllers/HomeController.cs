﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sharpsolutions.Edt.Web.Models;
using System.Configuration;
using Microsoft.WindowsAzure;
using Sharpsolutions.Edt.System;

namespace Sharpsolutions.Edt.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SettingsModel model = new SettingsModel();
            model.ApiServiceBase = CloudConfigurationManager.GetSetting(Settings.Api.Services);

            return View(model);
        }
    }
}