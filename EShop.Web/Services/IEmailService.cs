﻿using System.Threading.Tasks;

namespace EShop.Web.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}