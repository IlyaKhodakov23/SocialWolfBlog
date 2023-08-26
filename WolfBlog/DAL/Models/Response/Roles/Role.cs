﻿using Microsoft.AspNetCore.Identity;

namespace WolfBlog.DAL.Models.Response.Roles
{
    public class Role : IdentityRole
    {
        //Id, Name, NormalizedName,  -> распологаются в классе родителя
        public int? SecurityLvl { get; set; } = null;
    }
}
