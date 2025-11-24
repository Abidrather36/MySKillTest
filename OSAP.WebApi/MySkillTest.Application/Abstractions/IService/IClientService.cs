using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IClientService
    {
        Task<ApiResponse<IEnumerable<ClientResponseModel>>> GetAllClients();
        Task<ApiResponse<ClientResponseModel>> GetClientById(int clientId);
        Task<ApiResponse<ClientResponseModel>> AddClient(ClientRequestModel model);
        Task<ApiResponse<ClientResponseModel>> UpdateClient(ClientUpdateModel model);
        Task<ApiResponse<ClientResponseModel>> DeleteClient(int clientId);
    }

}
