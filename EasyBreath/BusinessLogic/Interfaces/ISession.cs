using Domain.Entities.Response;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
     public interface ISession
     {
          CookieResponse GenCookie(UCookieData utoken);
          ServiceResponse ValidateUserCredential(ULoginData user);
     }
}
