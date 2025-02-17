﻿using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantsController(IRestaurantData restaurantData) {
            this.restaurantData = restaurantData;
        }


        // GET: Restaurants
        public ActionResult Index()
        {
            var model = restaurantData.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = restaurantData.GetRestaurantById(id);
            return View(model);
        }

    }
}