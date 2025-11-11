//using Microsoft.Owin.Security.OAuth;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace OSAP.WebApi.Models
//{
//    public class OSAPAuthorizationServerProvider : OAuthAuthorizationServerProvider
//    {
//        //private readonly AccountRepository iUserRepository;
//        //private readonly IUserRoleRepository iUserRoleRepository;
//        //public OSAPAuthorizationServerProvider(IUserRepository iUserRepository, IUserRoleRepository iUserRoleRepository)
//        //{
//        //    this.iUserRepository = iUserRepository;
//        //    this.iUserRoleRepository = iUserRoleRepository;
//        //}
//        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
//        {
//            context.Validated();
//        }
//        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
//        {
//            try
//            {
//                AccountRepository iUserRepository = new AccountRepository();
//                var user = await iUserRepository.AuthenticateUser(context.UserName, context.Password);
//                if (user == null)
//                {
//                    context.SetError("invalid_grant", "Provided username and password is incorrect");
//                    return;
//                }
//                else
//                {
//                    var userModel = Mapper.Map<UserMaster, UserMasterModel>(user);
//                    var userRoles = await iUserRepository.GetUserRoleByUserId(userModel.UserId);
//                    var userRoleModels = Mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleModel>>(userRoles);
//                    var userFirstRole = userRoleModels.FirstOrDefault();
//                    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
//                    identity.AddClaim(new Claim(ClaimTypes.Role, userFirstRole.RoleId.ToString()));
//                    identity.AddClaim(new Claim(ClaimTypes.Name, userModel.UserName));
//                    identity.AddClaim(new Claim("Email", userModel.UserName));
//                    context.Validated(identity);
//                }
//            }
//            catch (Exception e)
//            {
//                return;
//            }
//        }
//    }
//}