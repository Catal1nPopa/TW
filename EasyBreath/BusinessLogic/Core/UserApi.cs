using Domain.Entities.Response;
using Domain.Entities.User;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Core
{
     public class UserApi
     {
          public ServiceResponse ReturnCredentialStatus(ULoginData user)
          {
               return new ServiceResponse { Status = true, StatusMessage = string.Empty };
          }
          public CookieResponse ReturnStatusCookie(UCookieData utoken)
          {
               return new CookieResponse { Data = DateTime.Now, Cookie = "123" };
          }
     }
}
