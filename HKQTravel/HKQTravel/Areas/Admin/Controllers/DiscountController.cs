﻿using HKQTravel.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKQTravel.Areas.Admin.Controllers
{
    public class DiscountController : Controller
    {
        // GET: Admin/Discount
        HKQTravelDataContext data = new HKQTravelDataContext();
        public ActionResult Index(int? page)
        {
            int pagenumber = (page ?? 1);
            int pagesize = 5;
            return View(data.discounts/*.Where(p=>p.Status != 0)*/.ToList().ToPagedList(pagenumber, pagesize));
        }
       
    }
}