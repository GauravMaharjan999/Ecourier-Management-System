using BusinessLayer.BaseRepository;
using ClientNotifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modellayer.Models.Enums;
using Modellayer.Models;
using StudentManagementSystem.ApplicationController;
using static ClientNotifications.Helpers.NotificationHelper;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class DeliveryManController : BaseController
    {

        private readonly IBaseRepository _baseRepository;
        private readonly IClientNotification _clientNotification;
        public DeliveryManController(IBaseRepository baseRepository, IClientNotification clientNotification)
        {


            _baseRepository = baseRepository;
            _clientNotification = clientNotification;

        }


        [HttpGet]
        public IActionResult Index()

        {
            return PartialView();

        }



        [HttpGet]
        public async Task<GridIndexData> GridIndex()

        {

            try
            {
                var result = _baseRepository.GetAllList<DeliveryMan>().ToList();
                GridIndexData gridIndexData = new GridIndexData();


                gridIndexData.curPage = 1;
                gridIndexData.dataRow = result;

                gridIndexData.totalRecords = result.Count();


                return gridIndexData;


            }
            catch (Exception ex)
            {

                throw;
            }




        }


        [HttpGet]
        public async Task<IActionResult> Create()

        {
            return PartialView();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(DeliveryMan model)
        {

            if (ModelState.IsValid)

            {

                var result = await _baseRepository.Create(model);

                if (result == null)
                {


                    _clientNotification.AddToastNotification("Error occured",
                                      NotificationType.error,
                                      new ToastNotificationOption
                                      {
                                          ProgressBar = true,
                                          PositionClass = "toast-bottom-right",
                                          CloseButton = true
                                      });
                    return View(result);
                }

                _clientNotification.AddToastNotification("Successfully Created",
                                     NotificationType.success,
                                     new ToastNotificationOption
                                     {
                                         ProgressBar = true,
                                         PositionClass = "toast-bottom-right",
                                         CloseButton = true
                                     });
                return RedirectToAction("Index");
            }


            return PartialView(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)

        {
            try
            {

                var result = _baseRepository.GetAllList<DeliveryMan>().Where(x => x.Id == Id).FirstOrDefault();


                if (result != null)
                {

                    return PartialView("Create", result);
                }
                else
                {
                    RedirectToAction("Index");
                }


            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(DeliveryMan model)

        {
            try
            {


                if (ModelState.IsValid)
                {
                    var result1 = await _baseRepository.UpdateModel<DeliveryMan>(model);

                    if (result1.ResultType == ResultTypeEnum.Failed || result1.ResultType == ResultTypeEnum.Exception)
                    {

                        _clientNotification.AddToastNotification("Error occured",
                              NotificationType.error,
                              new ToastNotificationOption
                              {
                                  ProgressBar = true,
                                  PositionClass = "toast-bottom-right",
                                  CloseButton = true
                              });
                        return PartialView(model);
                    }


                    _clientNotification.AddToastNotification("Successfully Created",
                                         NotificationType.success,
                                         new ToastNotificationOption
                                         {
                                             ProgressBar = true,
                                             PositionClass = "toast-bottom-right",
                                             CloseButton = true
                                         });
                    return RedirectToAction("Index");
                }



            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }


        [HttpGet]
        public async Task<IActionResult> Details(int Id)

        {

            try
            {

                var result = _baseRepository.GetAllList<DeliveryMan>().Where(x => x.Id == Id).FirstOrDefault();


                if (result == null)
                {

                    _clientNotification.AddToastNotification("Error occured",
                           NotificationType.error,
                           new ToastNotificationOption
                           {
                               ProgressBar = true,
                               PositionClass = "toast-bottom-right",
                               CloseButton = true
                           });

                    RedirectToAction("Index");
                }

                return View("Details", result);



            }
            catch (Exception ex)
            {

                throw;
            }


        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)

        {

            try
            {

                var result = _baseRepository.GetAllList<DeliveryMan>().Where(x => x.Id == Id).FirstOrDefault();


                if (result == null)
                {

                    _clientNotification.AddToastNotification("Error occured",
                           NotificationType.error,
                           new ToastNotificationOption
                           {
                               ProgressBar = true,
                               PositionClass = "toast-bottom-right",
                               CloseButton = true
                           });

                    return RedirectToAction("Index");
                }

                return View("Details", result);


            }
            catch (Exception ex)
            {

                throw;
            }

        }



        [HttpPost]
        public async Task<IActionResult> Delete(DeliveryMan model)
        {

            if (!ModelState.IsValid)
            {
                return View("Details", model);
            }

            var result = await _baseRepository.Delete<DeliveryMan>(model.Id);


            if (result == null)
            {
                _clientNotification.AddToastNotification("Error occured",
                         NotificationType.error,
                         new ToastNotificationOption
                         {
                             ProgressBar = true,
                             PositionClass = "toast-bottom-right",
                             CloseButton = true
                         });
                return View("Details", model);
            }
            _clientNotification.AddToastNotification("Successfully Deleted",
                                  NotificationType.success,
                                  new ToastNotificationOption
                                  {
                                      ProgressBar = true,
                                      PositionClass = "toast-bottom-right",
                                      CloseButton = true
                                  });

            return RedirectToAction("Index");
        }





    }
}
