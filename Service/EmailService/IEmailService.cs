using project_management_system_backend.Models;

namespace project_management_system_backend.Service.EmailService
{
    public interface IEmailService
    {


        void SendEmail(EmailDto request);

    }
}


