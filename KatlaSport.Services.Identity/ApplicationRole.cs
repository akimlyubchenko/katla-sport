﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace KatlaSport.Services.Identity
{
    /// <summary>
    /// Represents an application role.
    /// </summary>
    public class ApplicationRole : IdentityRole, IApplicationRole
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
        }
    }
}