﻿using AutoMapper;
using FinalYearProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalYearProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private CoursesService _courseService;
        public CourseController(CoursesService courseService)
        {
            _courseService = courseService;
            
        }

        [HttpGet("{prof_id}")]
        public IActionResult GetManagedCourses(int prof_id)
        {
            return Ok(_courseService.GetManagedCourses(prof_id));
        }
    }
}
