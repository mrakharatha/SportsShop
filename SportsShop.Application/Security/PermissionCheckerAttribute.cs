﻿using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SportsShop.Application.Interfaces;

namespace SportsShop.Application.Security
{
  
   public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private IPermissionService _permissionService;
        private readonly int _permissionId;
        public PermissionCheckerAttribute(int permissionId)
        {
            _permissionId = permissionId;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService = (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));

            var currentUserId = int.Parse(context.HttpContext.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);

            if (_permissionService==null||!_permissionService.CheckPermission(_permissionId, currentUserId))
                context.Result = new RedirectResult("/Permission");
        }
    }
}
