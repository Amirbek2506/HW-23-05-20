using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ASR.NETCoreMVS.Models.Persons;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASR.NETCoreMVS.Controllers
{
    public class PersonController : Controller
    {
        private string ConnString = "Data Source=Amirbek;Initial Catalog=AlifAcademy;Integrated Security=True";
        [HttpGet]
        public IActionResult Read(int? Id)
        {
            using (IDbConnection db = new SqlConnection(ConnString))
            {
                if (Id == null)
                    return View(db.Query<PersonViewModel>("SELECT * FROM PERSON").ToList<PersonViewModel>());
                else
                {
                    return View(db.Query<PersonViewModel>($"SELECT * FROM PERSON Where(Id={Id})").ToList<PersonViewModel>());
                }
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonViewModel person)
        {
            using (IDbConnection db = new SqlConnection(ConnString))
            {
                db.Execute($"INSERT INTO PERSON(LastName,FirstName,MiddleName) VALUES('{person.LastName}','{person.FirstName}','{person.MiddleName}')");
            }
            return RedirectToAction("Read");
        }
        [HttpGet]
        public IActionResult Scan()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetResultOfScan(PersonViewModel person)
        {
            using (IDbConnection db = new SqlConnection(ConnString))
            {
                return View(db.Query<PersonViewModel>($"SELECT * FROM PERSON WHERE (LastName Like '%{person.LastName}%') AND (FirstName Like '%{person.FirstName}%') AND (MiddleName Like '%{person.MiddleName}%')").ToList<PersonViewModel>());
            }
        }
        [HttpGet]
        public IActionResult ScanById()
        {
            return View();
        }
    }
}