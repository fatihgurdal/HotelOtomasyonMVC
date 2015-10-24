using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using WebApplication1.Models;
using System.Security.Cryptography;
using System.Text;
using WebApplication1.Convert;

namespace WebApplication1.Controllers
{
    public class UserAuthoritiesController : BaseController
    {
        private readonly IServiceUserAuthoritys _serviceUserAuthoritys;
        private readonly IServiceAuthoritys _serviceAuthoritys;
        private readonly IServiceUsers _serviceUsers;

        public static string MD5Sifrele(string metin)
        {
            // MD5CryptoServiceProvider nesnenin yeni bir instance'sını oluşturalım.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();


            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }

        public UserAuthoritiesController(IServiceUserAuthoritys serviceUserAuthoritys, IServiceAuthoritys serviceAuthoritys, IServiceUsers serviceUsers)
        {
            _serviceUserAuthoritys = serviceUserAuthoritys;
            _serviceAuthoritys = serviceAuthoritys;
            _serviceUsers = serviceUsers;
        }

        //[HttpPost]
        public ActionResult GetUserAuthoritieses(int userId)
        {
            IEnumerable<UserAuthorities> listsUserAuthoritieses = _serviceUserAuthoritys.GetAll().Where(x => x.Authority.SubAuthority == null).OrderBy(x => x.AuthorityId).ToList();
            return View(listsUserAuthoritieses);

        }

        public ActionResult Login()
        {
            return View(false);
        }

        [HttpPost]
        public ActionResult Login(string userName, string password, string returnUrl = "/")
        {
            IEnumerable<Users> users = _serviceUsers.GetAll();
            string hashedPassword = MD5Sifrele(password);
            Users curUser = users.Where(s => s.UserName == userName && s.Password == hashedPassword).FirstOrDefault();

            if (curUser != null)
            {
                Session["curUser"] = curUser;
                return Redirect(returnUrl);
            }
            return View(true);
        }
    }
}