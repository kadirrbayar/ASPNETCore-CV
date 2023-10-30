using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ToDoListController : Controller
    {
        ToDoListManager _toDoListManager = new ToDoListManager(new EfToDoListDal());
        [HttpPost]
        public IActionResult Index(ToDoList p)
        {
            p.Status = true;
            _toDoListManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteToDo(int id)
        {
            var find = _toDoListManager.get(id);
            _toDoListManager.TDelete(find);
            var values = JsonConvert.SerializeObject(find);
            return Json(values);
        }
    }
}
