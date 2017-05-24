﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using NHibernate;
using PhotoSharer.Models.Repository.Interface;
using NHibernate.Linq;

namespace PhotoSharer.Models.Repository
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        private ISessionFactory SessionFactory;

        public LoginRepository(ISessionFactory sessionFactory) : base(sessionFactory)
        {
            SessionFactory = sessionFactory;
        }

        public AppUser GetUserByLoginInfo(UserLoginInfo loginInfo)
        {
            using (var session = SessionFactory.OpenSession())
            {
                var user = session.Query<Login>()
                    .Where(login => login.LoginProvider == loginInfo.LoginProvider && login.ProviderKey == loginInfo.ProviderKey)
                        .Select(login => login.User).ToList().FirstOrDefault();
                return user;
            }
        }
    }
}