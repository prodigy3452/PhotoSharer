﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharer.Models.Repository.Interface
{
    public interface IUserRepository : IRepository<AppUser>
    {
        AppUser GetByUserName(string userName);
    }
}
