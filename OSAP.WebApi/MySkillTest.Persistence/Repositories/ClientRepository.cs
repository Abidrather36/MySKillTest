using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Data;

namespace MySkillTest.Persistence.Repositories
{
    public class ClientRepository:BaseRepository<Client>,IClientRepository
    {
        private readonly MySkillTestDbContext context;

        public ClientRepository(MySkillTestDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<int> AddClient(Client client)
        {
            await context.Clients.AddAsync(client);  
            return   await context.SaveChangesAsync();
        }

        public Task<Client> DeleteClient(Guid clietnId)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Client>> GetAllClients()
        {
           var clients =await context.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client> GetClientById(Guid clientId)
        {
           var client=await context.Clients.FindAsync(clientId);
            return client;
           
        }

        public Task<Client> GetClientByName(string clientName)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateClient(Client client)
        {
            await Task.Run(()=> context.Clients.Update(client));
            return await context.SaveChangesAsync();
           
        }

        public Task<bool> UploadClientLogo(byte[] fileData, Guid clientId)
        {
            throw new NotImplementedException();
        }
    }
}
