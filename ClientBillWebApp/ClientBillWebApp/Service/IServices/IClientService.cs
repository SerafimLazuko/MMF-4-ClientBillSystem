using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientBillWebApp.Models;

namespace ClientBillWebApp.Service.IServices
{
    interface IClientService
    {
        ClientModel CreateClient();
        bool DeleteClient(Guid clientId);
        ClientModel GetClient(Guid clientId);
        void UpdateClient(Guid clientId);
    }
}