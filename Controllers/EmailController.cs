using Microsoft.AspNetCore.Mvc;
using project_management_system_backend.Models;
using project_management_system_backend.Service.EmailService;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using MimeKit;
using MimeKit.Text;

namespace project_management_system_backend.Controllers
{



    [Route("api/[controller]")]
        [ApiController]
        public class EmailController : ControllerBase

        {
            private readonly IEmailService _emailService;
            public EmailController(IEmailService emailService)
            {
                _emailService = emailService;
            }

            [HttpPost]
            public IActionResult SendEmail(EmailDto request)
            {

                _emailService.SendEmail(request);
                return Ok();


            }

        }
    }

