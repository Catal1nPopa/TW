using BusinessLogic.Core;
using BusinessLogic.Interfaces;
using Domain.Entities.Response;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
     public class SessionBL : UserApi, ISession
     {
          public ServiceResponse ValidateUserCredential(ULoginData user)
          {
               return ReturnCredentialStatus(user);
          }
          public CookieResponse GenCookie(UCookieData utoken)
          {
               return ReturnStatusCookie(utoken);
          }
     }
}
