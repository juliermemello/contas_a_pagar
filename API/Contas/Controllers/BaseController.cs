using Microsoft.AspNetCore.Mvc;

namespace Contas.Controllers
{
    public class BaseController : Controller
    {
        public void SetMessage(string text, bool error = false)
        {
            TempData["Message.Text"] = text;
            TempData["Message.Error"] = error;
        }

        public void ClearMessage()
        {
            SetMessage(null);
        }
    }
}
