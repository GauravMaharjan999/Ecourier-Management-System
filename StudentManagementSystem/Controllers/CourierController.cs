using BusinessLayer.BaseRepository;
using ClientNotifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Modellayer.Models;
using System.Linq;
using System.Threading.Tasks;
using static ClientNotifications.Helpers.NotificationHelper;

namespace StudentManagementSystem.Controllers
{
    [Authorize]
    public class CourierController : Controller
    {

        private readonly IBaseRepository _baseRepository;
        private readonly IClientNotification _clientNotification;
        public CourierController(IBaseRepository baseRepository, IClientNotification clientNotification)
        {
            _baseRepository = baseRepository;
            _clientNotification = clientNotification;
        }

        [AllowAnonymous]
        public IActionResult Index()

        {

            ViewBag.DeliveryManList = _baseRepository.GetAllList<DeliveryMan>().ToList();
            return View("Index");
        }



        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(Courier model)
        {

            ViewBag.DeliveryManList = _baseRepository.GetAllList<DeliveryMan>().ToList();
            if (!User.Identity.IsAuthenticated)
            {
                RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            model.AddedBy = User.Identity.Name;
            var result = await _baseRepository.Create(model);
            if (result != null)
            {

                _clientNotification.AddToastNotification("Successfully registered !!", NotificationType.success,
                                                      new ToastNotificationOption
                                                      {
                                                          ProgressBar = true,
                                                          PositionClass = "toast-bottom-right"
                                                      });

                var newModel = new Courier();

                return View("Index", newModel);
            }

            _clientNotification.AddToastNotification("Failed to register !!", NotificationType.error,
                                                    new ToastNotificationOption
                                                    {
                                                        ProgressBar = true,
                                                        PositionClass = "toast-bottom-right"
                                                    });
            return View("Index");
        }


    }
}
