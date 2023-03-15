using ClientNotifications;
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ClientNotifications.Helpers.NotificationHelper;
using Modellayer.Models;
using BusinessLayer.EmailSenderLogics;
using System.Net.Security;
using Microsoft.AspNetCore.Http.Internal;

namespace StudentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IEmailSender _emailSender;

        private readonly IClientNotification _clientNotification;


        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager
            ,IClientNotification clientNotification, IEmailSender emailSender)

        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _clientNotification = clientNotification;
            _emailSender= emailSender;  
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                TempData["ReturnUrl"] = returnUrl;
            }   
            return View();
        }

        [HttpPost]

        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)    
            {
            var returnUrl = TempData["ReturnUrl"]?.ToString();
          
            try
            {
                if (ModelState.IsValid)
                {

                    var result = await signInManager.PasswordSignInAsync(
                        model.Email, model.Password, model.RememberMe, false); // false: don't lock the account for failure

                    if (result.Succeeded)
                    {
                        // var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();


                        // var message = new Message(new string[] { "rijanmaharjan999@gmail.com" }, "Test mail with Attachments", "This is the content from our mail with attachments.", null);
                        //await _emailSender.SendEmailAsync(message);

                        if (User.IsInRole("Admin"))
                        {
                            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                        }
                        if (!string.IsNullOrEmpty(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        TempData["LoginStatus"] = true;
                        _clientNotification.AddToastNotification("Successfully loggedin",
                                            NotificationType.success,
                                            new ToastNotificationOption
                                            {
                                                ProgressBar = true,
                                                PositionClass = "toast-bottom-right",
                                                CloseButton = true
                                            });

                        _clientNotification.AddSweetNotification("success", "success", NotificationType.success);

                        ViewBag.LoginStatus = true;



                        return RedirectToAction("Index", "courier");
                        //var path = "/admin/student/index";
                        //return base.Redirect(path);
                        //need to define route in respective controller

                        //return RedirectToAction("index", "student");
                    }
                    _clientNotification.AddToastNotification("Login Failed!",
                                          NotificationType.error,
                                          new ToastNotificationOption
                                          {
                                              ProgressBar = true,
                                              PositionClass = "toast-bottom-right",
                                              CloseButton = true
                                          });
                    ModelState.AddModelError("Password", "Invalid Login Attempt");

                    ViewBag.LoginStatus = false;
                }
                return View("Login", model);

            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {/*
                    await signInManager.SignInAsync(user, isPersistent: false);//creates persistent cookies
                    return RedirectToAction("index", "student");*/
                    var AddRoleStatus = await userManager.AddToRoleAsync(user,"User");

                    if (AddRoleStatus.Succeeded)
                    {
                        TempData["RegisterStatus"] = true;
                        return RedirectToAction("Login", "Account");
                    }
                    foreach (var error in AddRoleStatus.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {


            return View();
        }




    }

}
