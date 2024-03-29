﻿using AutoMapper;
using Identity.Application.ViewModels;
using Identity.Domain.Interfaces.Services;
using Identity.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<UserViewModel>> Get()
        {
            var user = await _userService.GetAsync();

            return Ok(_mapper.Map<UserViewModel>(user));
        }

        [AllowAnonymous]
        [HttpGet("Get/{id}")]
        public async Task<ActionResult<UserViewModel>> Get(string id)
        {
            var user = await _userService.GetByIdAsync(id);

            return Ok(_mapper.Map<UserViewModel>(user));
        }

        [AllowAnonymous]
        [HttpPost("Add")]
        public async Task<ActionResult> Add(AddUserViewModel viewModel)
        {
            await _userService.InsertAsync(_mapper.Map<User>(viewModel));

            return Ok();
        }

        [HttpPut("Alter")]
        public async Task<ActionResult> Alter(AlterUserViewModel viewModel)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(viewModel));

            return Ok();
        }

        [HttpDelete("Remove")]
        public async Task<ActionResult> Remove()
        {
            await _userService.DeleteAsync();

            return Ok();
        }
    }
}
