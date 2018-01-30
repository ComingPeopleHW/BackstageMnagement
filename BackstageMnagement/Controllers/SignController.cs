using BackstageMnagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BackstageMnagement.Controllers
{
    /// <summary>
    /// Sign
    /// </summary>
    public class SignController : Controller
    {
        BackStageDbContext db = new BackStageDbContext();

        // GET: Login
        public ActionResult Sign()
        {
            return View();
        }

        /// <summary>
        /// 账号登陆验证&Cookie userName
        /// dbPassword=md5(formPassword)+"backstage"
        /// </summary>
        /// <param name="lI">登陆表单</param>
        /// <returns></returns>
        [HttpPost]
        public string SignVerification(LoginInfo lI)
        {
            var temAccount = db.AccountInfo.Find(lI.userName);
            if (temAccount != null)
            {
                MD5 mD5 = new MD5CryptoServiceProvider();
                byte[] passWord = Encoding.Default.GetBytes(lI.passWord);
                var tem = mD5.ComputeHash(passWord);  //md5加密
                string mD5Pwd = null;
                for (int i = 0; i < tem.Length; i++)
                {
                    mD5Pwd += tem[i].ToString("x2");  //x->转化为16进制 x2->每次都保留2位
                }
                mD5Pwd += "backstage";
                if (temAccount.PassWord == mD5Pwd && lI.whichType==temAccount.Permissions)
                {
                    HttpCookie cookie = Response.Cookies["cookie"];
                    cookie.Values.Set("userName", lI.userName);
                    cookie.HttpOnly = true;
                    cookie.Expires = DateTime.Now.AddHours(2.0);
                    Response.SetCookie(cookie);
                    Response.Cookies.Add(cookie);
                    return "登陆成功";
                }
            }
            return "0";
            
        }


        public ActionResult FindPsw()
        {
            return View();
        }

        /// <summary>
        /// 验证信息
        /// </summary>
        /// <param name="fC">接受前台表单信息</param>
        /// <returns></returns>
        [HttpPost]
        public string CheckInfo(FormCollection fC)
        {
            var userName = fC["userName"];
            var stringBirthDay = fC["birthDay"];
            var DateTimeBirthDay=Convert.ToDateTime(stringBirthDay);
            var temp = db.AccountInfo.Find(userName);
            if (temp != null && temp.BirthDay == DateTimeBirthDay)
            {
                
            }
            return "";
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpPost]
        public string CheckInfo1(string userName)
        {
            var a = userName;
            return "";
        }


        public string ChangePsw()
        {
            return "";
        }

    }
}