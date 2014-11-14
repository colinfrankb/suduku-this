using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySuduku.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [ActionName("Index")]
        public ActionResult ChooseDifficulty()
        {
            return View("ChooseDifficulty");
        }

        public ActionResult Play(int difficulty, bool runTests)
        {
            if (difficulty == 24 || difficulty == 30 || difficulty == 36)
            {
                ViewBag.Difficulty = difficulty;
                ViewBag.RunTests = runTests;
                return View();
            }
            throw new Exception("Difficulty level does not exist");
        }
	}
}