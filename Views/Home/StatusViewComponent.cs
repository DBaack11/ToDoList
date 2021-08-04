using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Views.Home
{
    public class StatusViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View(ViewBag.Statuses.Count());

    }
}
