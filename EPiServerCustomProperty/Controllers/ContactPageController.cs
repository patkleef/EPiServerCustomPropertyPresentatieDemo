using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServerCustomProperty.Models.Pages;

namespace EPiServerCustomProperty.Controllers
{
    public class ContactPageController : PageController<ContactPage>
    {
        public ActionResult Index(ContactPage currentPage)
        {
            return View(currentPage);
        }
    }
}