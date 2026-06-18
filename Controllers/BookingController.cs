using Microsoft.AspNetCore.Mvc;

namespace MRBS_BSES.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookMeeting()
        {
            return View();
        }
        public IActionResult MyBooking()
        {
            return View();
        }
    }
}
