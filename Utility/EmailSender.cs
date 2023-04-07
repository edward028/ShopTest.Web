using Microsoft.AspNetCore.Identity.UI.Services;

namespace ShopTest.Web.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string a)
        {
            return Task.CompletedTask;
        }
    }
}
