using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubOrgSearch.Models;

namespace GithubOrgSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OrganisationRepoDetails(OrgRepoDetails data)
        {
            return View("OrganisationRepoDetails", data);
        }
    }
}
