using Requisition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Requisition.Controllers
{
    public class BranchController : Controller
    {

        Branch[] branchList =
        {
            new Branch {Id=1,Name="Main Branch",Address="Dhaka",Phone="12345678",Email="info@",IsMainBranch=1,IsActive=1 },
            new Branch {Id=2,Name="Branch A",Address="Dhaka",Phone="12345678",Email="info@",IsMainBranch=2,IsActive=1 },
            new Branch {Id=3,Name="Branch B",Address="Dhaka",Phone="12345678",Email="info@",IsMainBranch=2,IsActive=1 },
            new Branch {Id=4,Name="Branch C",Address="Dhaka",Phone="12345678",Email="info@",IsMainBranch=2,IsActive=1 },
        };

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(branchList);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Branch branch = branchList.Where(x => x.Id == id).FirstOrDefault();
            return View(branch);
        }

    }
}