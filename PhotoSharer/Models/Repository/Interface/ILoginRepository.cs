﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharer.Models.Repository.Interface
{
    public interface ILoginRepository : IRepository<Login>
    {
        AppUser GetUserByLoginInfo(UserLoginInfo loginInfo);
       
    }
}
