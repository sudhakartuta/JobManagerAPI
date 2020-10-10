using JobManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagerAPI.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<TblUser> WithoutPasswords(this IEnumerable<TblUser> users)
        {
            if (users == null) return null;

            return users.Select(x => x.WithoutPassword());
        }

        public static TblUser WithoutPassword(this TblUser user)
        {
            if (user == null) return null;

            user.Password = null;
            return user;
        }
    }
}
