using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public async Task<ApiResponse<ClientResponseModel>> AddClient(ClientRequestModel model)
        {

            try
            {
                var entity = new Client
                {
                    ClientName = model.ClientName,
                    ClientConfigurationJson = model.ClientConfigurationJson,
                    CreatedBy = model.CreatedBy,
                    CreatedDate = DateTimeOffset.Now,
                    ApplicationUri = model.ApplicationUri,
                    LoweredApplicationUri = model.ApplicationUri?.ToLowerInvariant(),
                    IsActive = true
                };

                var clientAdded = await clientRepository.AddClient(entity);
                if (clientAdded > 0)
                {
                    var res = new ClientResponseModel()
                    {
                        ClientId = entity.ClientId,
                        ClientName = entity.ClientName,
                        ClientConfigurationJson = entity.ClientConfigurationJson,
                        CreatedDate = (DateTimeOffset?)entity.CreatedDate ?? DateTimeOffset.UtcNow,
                        IsActive=entity.IsActive

                    };
                    return ApiResponse<ClientResponseModel>.SuccessResponse(res, ApiMessages.ClientManagement.ClientAdded, HttpStatusCodes.OK);
                }
                return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
            }
            catch (Exception ex)
            {
                return ApiResponse<ClientResponseModel>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message}", HttpStatusCodes.BadRequest);
            }
        }

      
        public async Task<ApiResponse<IEnumerable<ClientResponseModel>>> GetAllClients()
        {
            var clients = await clientRepository.GetAllClients();
            if (clients is null)
            {
                return ApiResponse<IEnumerable<ClientResponseModel>>.ErrorResponse(ApiMessages.ClientManagement.ClientNotFound, HttpStatusCodes.BadRequest);
            }
            var res = clients.Select(x => new ClientResponseModel
            {
                ClientId = x.ClientId,
                ClientName = x.ClientName,
                ClientConfigurationJson = x.ClientConfigurationJson,
                LoweredApplicationUri = x.LoweredApplicationUri,
                IsActive=x.IsActive
            });

            return ApiResponse<IEnumerable<ClientResponseModel>>.SuccessResponse(res, $"{res.Count()} Clients Found", HttpStatusCodes.OK);
        }


        public async Task<ApiResponse<ClientResponseModel>> GetClientById(int clientId)
        {
            var client = await clientRepository.GetClientById(clientId);
            if (client is null)
            {
                return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.ClientManagement.ClientNotFound, HttpStatusCodes.BadRequest);
            }
            return ApiResponse<ClientResponseModel>.SuccessResponse(new ClientResponseModel
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                ClientConfigurationJson = client.ClientConfigurationJson,
                IsActive=client.IsActive
            }, ApiMessages.ClientManagement.ClientFound, HttpStatusCodes.OK);
        }

        public async Task<ApiResponse<ClientResponseModel>> UpdateClient(ClientUpdateModel model)
        {
            var client = await clientRepository.GetClientById(model.ClientId);
            if (client is null)
            {
                return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.ClientManagement.ClientNotFound, HttpStatusCodes.BadRequest);
            }
            client.ClientName = model.ClientName;
            client.ApplicationUri = model.ApplicationUri;
            client.ModifiedBy = default;
            var updatedCLient = await clientRepository.UpdateClient(client);
            if (updatedCLient > 0)
            {
                return ApiResponse<ClientResponseModel>.SuccessResponse(new ClientResponseModel
                {
                    ClientId = client.ClientId,
                    ClientName = client.ClientName
                }, ApiMessages.ClientManagement.ClientUpdated, HttpStatusCodes.OK);
            }
            return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
        }
        public async Task<ApiResponse<ClientResponseModel>> DeleteClient(int clientId)
        {
           var client=await clientRepository.GetByIdAsync(clientId);
            if(client is null)
            {
                return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.ClientManagement.ClientNotFound, HttpStatusCodes.BadRequest);
            }
            client.IsActive = false;
            var deletedClient = await clientRepository.UpdateClient(client);
            if (deletedClient is > 0)
            {

                return ApiResponse<ClientResponseModel>.SuccessResponse(new ClientResponseModel
                {
                    ClientId = client.ClientId,
                    ClientName = client.ClientName,
                    IsActive = client.IsActive

                }, ApiMessages.ClientManagement.ClientDeletedSuccesfully, HttpStatusCodes.OK);
            }
            return ApiResponse<ClientResponseModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
          
        }

    }

}
