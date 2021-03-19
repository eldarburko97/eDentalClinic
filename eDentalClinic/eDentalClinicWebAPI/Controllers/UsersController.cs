﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using eDentalClinic.Model;
using eDentalClinic.Model.Requests;
using eDentalClinicWebAPI.Filters;
using eDentalClinicWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eDentalClinicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<List<User>> GetAll([FromQuery]UserSearchRequest search)
        {
            return _service.GetAll(search);
        }

        [HttpGet("{userId}")]
        public ActionResult<User> GetById(int userId)
        {
            return _service.GetById(userId);
        }

        [HttpPost]
        public ActionResult<User> Insert(UserInsertRequest request)
        {
            try
            {
                return Ok(_service.Insert(request));
            }
            catch (DbUpdateException)
            {
                return BadRequest("Duplicate user");              
            }
        }

        [HttpPut("{id}")]
        public ActionResult<User> Update(int id, [FromBody]UserInsertRequest request)
        {
            try
            {
                return Ok(_service.Update(id, request));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }       
    }
}