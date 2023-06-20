using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstraction.Common.Email
{
    public interface IEmailService
    {
        void Send(string from, string to, string subject, string html);
    }
}
