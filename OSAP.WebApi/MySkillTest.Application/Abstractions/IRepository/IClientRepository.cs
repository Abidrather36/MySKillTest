using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IClientRepository:IBaseRepository<Client>
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientById(Guid clientId);
        Task<Client> GetClientByName(string clientName);
        Task<int> AddClient(Client client);
        Task<int> UpdateClient(Client client);
        Task<Client> DeleteClient(Guid clietnId);
        Task<bool> UploadClientLogo(byte[] fileData, Guid clientId);
    }
}
