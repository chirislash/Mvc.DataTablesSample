using DataTablesFork.Models;
using Mvc.JQuery.DataTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DataTablesFork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }       
        public DataTablesResult<MyViewModelClass> GetViewModel(DataTablesParam dataTableParam)
        {
            List<MyViewModelClass> model = new List<MyViewModelClass>();
            MyViewModelClass element;
            int id = 1;
            string state;
            string country;
            string user;
            string supplier;
            string status;
            string postalCode;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    if (j==1)
                    {
                        country = "US";
                        state = "NY";
                        user = "me";
                        supplier = "american Supplier";
                        status = "pending";
                        postalCode = "10001-A";
                    }
                    else
                    {
                        country = "CA";
                        state = "ON";
                        user = "you";
                        supplier = "canadian Supplier";
                        status = "completed";
                        postalCode = "10001-B";
                    }
                    element = new MyViewModelClass() {
                        Id = id,                        
                        CreationDate = DateTime.UtcNow.AddMonths(-2),
                        Status = status,
                        PostalCode = postalCode,
                        Supplier = supplier,
                        StatusUpdateDate = DateTime.UtcNow,
                        CreationUser = user,                        
                        CountryData = country,
                        State = state,                                                
                        PONumber = i + "-" + j,
                        actions = false,
                    };
                    model.Add(element);
                    id++;
                }
            }            
            return DataTablesResult.Create(model.AsQueryable(), dataTableParam,
            uv => new
            {
            });
        }

    }
}