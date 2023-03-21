using BusinessLogic.Interfaces;
using Domain.Entities.Response;
using Domain.Entities.User;
using EasyBreath.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace EasyBreath.web.Controllers
{
     public class LoginController : Controller
     {
          private readonly ISession _session;

          public LoginController()
          {
               var bl = new BussinesLogic();
               _session = bl.GetSessionBL();
          }
          // GET: Login
          public ActionResult Index()
          {
               var user = new ULoginData { Password = "ecaterina", UserName = "aaa"};
               ServiceResponse UValidate = _session.ValidateUserCredential(user); 
              
               //suplimentar//
               if(UValidate.Status) 
               {
                    var utoken = new UCookieData { UserName = user.UserName, Token = "abcd" };
                    CookieResponse cookie = _session.GenCookie(utoken);
                    {

                    }
               }
               return View();
          }
     }
}