using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Interfaces.Services
{
    public interface IEmailService
    {
        bool SendMail(string to, string massage);
    }
}
