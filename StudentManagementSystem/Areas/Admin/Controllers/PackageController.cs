using BusinessLayer.ClassLogics;
using ClientNotifications;
using Microsoft.AspNetCore.Mvc;
using Modellayer.Models.Enums;
using Modellayer.Models;
using static ClientNotifications.Helpers.NotificationHelper;
using StudentManagement.ViewModels;
using StudentManagementSystem.ApplicationController;
using System.Threading.Tasks;
using System;
using System.Linq;
using BusinessLayer.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PackageController : BaseController
    {

        private readonly IBaseRepository _baseRepository;
        private readonly IClientNotification _clientNotification;
        public PackageController(IBaseRepository baseRepository, IClientNotification clientNotification)
        {


            _baseRepository = baseRepository;
            _clientNotification = clientNotification;

        }



        [HttpGet]
        public IActionResult Index(int pq_curpage, int pq_rPP, string pq_filter)

        {

            return PartialView();

        }

        [HttpGet]
        public async Task<GridIndexData> GridIndex()

        {

            try
            {
                var result = User.IsInRole("Admin") ? _baseRepository.GetAllList<Courier>().Include(x=> x.DeliveryMan).ToList() : _baseRepository.GetAllList<Courier>().Include(x => x.DeliveryMan).Where(x => x.AddedBy == User.Identity.Name).ToList();
            
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
            

            ViewBag.DeliveryManList = _baseRepository.GetAllList<DeliveryMan>().ToList();
            return PartialView();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Courier model)
        {
            if (ModelState.IsValid)

            {
                model.AddedBy = User.Identity.Name;

                var result = await _baseRepository.Create(model);

                if (result==null)
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
                ViewBag.DeliveryManList = _baseRepository.GetAllList<DeliveryMan>().ToList();

                var result = _baseRepository.GetAllList<Courier>().Include(x=> x.DeliveryMan).Where(x=> x.Id == Id).FirstOrDefault();


                if (result != null)
                {
                   
                    return PartialView("Create",result);
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
        public async Task<IActionResult> Edit(Courier model)

        {
            try
            {


                if (ModelState.IsValid)
                {
                    model.ModifiedBy = User.Identity.Name;
                    var result1 = await _baseRepository.UpdateModel<Courier>(model);

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

                var result =  _baseRepository.GetAllList<Courier>().Include(x => x.DeliveryMan).Where(x => x.Id == Id).FirstOrDefault();


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

                return View("Details",result);



            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)

        {

            try
            {

                var result = _baseRepository.GetAllList<Courier>().Include(x => x.DeliveryMan).Where(x => x.Id == Id).FirstOrDefault();


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
             
                return View("Details",result);


            }
            catch (Exception ex)
            {

                throw;
            }


        }



        [HttpPost]
        public async Task<IActionResult> Delete(Courier model)
        {

            var result = await _baseRepository.Delete<Courier>(model.Id);


            if (result==null)
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
