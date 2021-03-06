﻿using LibraryApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public class CacheController : ControllerBase
    {
        private ISystemTime Clock;

        public CacheController(ISystemTime clock)
        {
            Clock = clock;
        }
        [HttpGet("/time1")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 10 )]
        public ActionResult GetTheTime()
        {
            return Ok(Clock.GetCurrent().ToLongTimeString());
        }
    }
}
