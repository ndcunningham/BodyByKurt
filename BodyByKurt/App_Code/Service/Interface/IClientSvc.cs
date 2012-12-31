using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;

namespace BodyByKurt.Service.Interface
{
    public interface IClientSvc
    {
        List<Client> selectAllClients();
        List<Client> searchClients(Client obj);
        Client selectClient(String key);
        Boolean insertClient(Client obj);
        Boolean updateClient(Client obj);
        Boolean deleteClient(Client obj);
    }
}
