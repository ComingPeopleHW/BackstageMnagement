using BackstageMnagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackstageMnagement.Controllers
{
    public class ArticleController : Controller
    {
        BackStageDbContext db = new BackStageDbContext();
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddArticle()
        {
            HttpCookie temp = Request.Cookies["cookie"];
            if (temp != null)
            {
                ViewBag.userName = temp["userName"];
                return View();
            }
            return View("~/Views/Sign/Sign.cshtml");
        }

        /// <summary>
        /// 存储文章
        /// </summary>
        /// <param name="aI"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        [HttpPost]
        public string ArticleContent(ArticleInfo aI)
        {
            HttpCookie temp = Request.Cookies["cookie"];
            string userName = null;
            if (temp != null)
            {
                userName = temp["userName"];
                aI.User = userName;
                aI.PublishDate = DateTime.Now;
                db.ArticleInfo.Add(aI);
                db.SaveChanges();
                return "发布成功";
            }
            return "";
        }

        /// <summary>
        /// 存储草稿
        /// </summary>
        /// <param name="draft"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        [HttpPost]
        public string DraftContent(Draft draft)
        {
            HttpCookie temp = Request.Cookies["cookie"];
            string userName = null;
            if (temp != null)
            {
                userName = temp["userName"];
                draft.Status = "未发布";
                draft.User = userName;
                db.Draft.Add(draft);
                db.SaveChanges();
                return "发布成功";
            }
            return "";
        }

        /// <summary>
        /// 退出网页
        /// </summary>
        [HttpPost]
        public void Exit()
        {
            HttpCookie temp = Request.Cookies["cookie"];
            if (temp != null)
            {
                temp.Expires = DateTime.Now.AddHours(-1);
                Response.AppendCookie(temp);
            }
        }
    }
}