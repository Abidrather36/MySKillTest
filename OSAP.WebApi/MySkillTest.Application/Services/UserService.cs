using MySkillTest.Application.Abstractions.IEmailService;
using MySkillTest.Application.Abstractions.Iidentity;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Application.Utils;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IContextService contextService;
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IEmailService emailService;

        public UserService(IUserRepository userRepository, IContextService contextService, IUserRoleRepository userRoleRepository, IEmailService emailService)
        {
            this.userRepository = userRepository;
            this.contextService = contextService;
            this.userRoleRepository = userRoleRepository;
            this.emailService = emailService;
        }

        //public async Task<ApiResponse<UserMasterModel>> CreateUser(UserMasterModel model)
        //{
        //    var authUserId = contextService.UserId();
        //    var existingUser = await userRepository.GetUserByUserName(model.UserName);
        //    if (existingUser != null)
        //    {
        //        await emailService.SendUserExistsNotificationAsync(existingUser.UserName, existingUser.Name);
        //        return ApiResponse<UserMasterModel>.ErrorResponse(ApiMessages.User.UserAlreadyExists, HttpStatusCodes.BadRequest);
        //    }
        //    //string rawPassword = Guid.NewGuid().ToString("n").Substring(0, 8);
        //    //var salt = AppEncryption.GenerateSalt();
        //    string rawPassword = AppEncryption.GenerateRandomPassword(model.UserName);
        //    string salt = AppEncryption.GenerateSalt();
        //    var hashedPassword = AppEncryption.CreatePassword(rawPassword, salt);

        //    UserMaster userMaster = new UserMaster();
        //    userMaster.UserId = Guid.NewGuid();
        //    userMaster.UserName = model.UserName;
        //    userMaster.Password = hashedPassword;
        //    userMaster.Salt = salt;
        //    userMaster.LoweredUserName = model.UserName.ToLower();
        //    userMaster.LastActivityDate = DateTimeOffset.UtcNow;
        //    userMaster.LastLoginDate = DateTimeOffset.UtcNow;
        //    userMaster.LastPasswordChangedDate = DateTimeOffset.UtcNow;
        //    userMaster.LastLockoutDate = DateTimeOffset.UtcNow;
        //    userMaster.PasswordFormat = 1;
        //    userMaster.CreatedBy = authUserId;
        //    userMaster.ClientId = model.ClientId;
        //    userMaster.FailedPasswordAttemptCount = 0;
        //    userMaster.PasswordResetRequestActive = false;
        //    userMaster.IsVerified = false;
        //    userMaster.IsLockedOut = false;
        //    userMaster.CreatedDate = DateTime.UtcNow;
        //    userMaster.ModifiedDate = DateTime.UtcNow;

        //    var userAdded = await userRepository.AddUser(userMaster);

        //    UserRole userRole = new UserRole()
        //    {
        //        UserRoleId=Guid.NewGuid(),
        //        RoleId = model.RoleId,
        //        UserId = userMaster.UserId,
        //        ClientId = model.ClientId,
        //        CreatedBy = model.ClientId,
        //        CreatedDate = DateTimeOffset.Now
        //    };
        //    var userRoleAdded = await userRoleRepository.AddUserRole(userRole);
        //    if (userRoleAdded > 0)
        //    {
        //        var emailSent = await emailService.SendUserCredentialsEmailAsync(
        //     userMaster.UserName,   // email
        //     userMaster.Name,       // full name
        //     rawPassword            // plain generated password
        // );

        //        if (emailSent)
        //        {
        //            UserMasterModel res = new UserMasterModel
        //            {
        //                UserId = userMaster.UserId,
        //                UserName = userMaster.UserName,
        //                ClientId = userRole.ClientId,
        //                CreatedDate = userMaster.CreatedDate,
        //                LoweredUserName = userMaster.LoweredUserName,
        //                Name = userMaster.Name
        //            };

        //            return ApiResponse<UserMasterModel>.SuccessResponse(
        //                res,
        //                ApiMessages.User.UserAddedSuccessfully,
        //                HttpStatusCodes.Created
        //            );
        //        }
        //        return ApiResponse<UserMasterModel>.ErrorResponse("Couldn't send Email Please try again ", HttpStatusCodes.BadRequest);
        //    }
        //    return ApiResponse<UserMasterModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
        //}
        public async Task<ApiResponse<UserMasterModel>> CreateUser(UserMasterModel model)
        {
            var authUserId = contextService.UserId();

            var existingUser = await userRepository.GetUserByUserName(model.UserName);
            if (existingUser != null)
            {
                await emailService.SendUserExistsNotificationAsync(existingUser.UserName, existingUser.Name);
                return ApiResponse<UserMasterModel>.ErrorResponse(ApiMessages.User.UserAlreadyExists, HttpStatusCodes.Conflict);
            }


            string rawPassword = AppEncryption.GenerateRandomPassword(model.UserName);
            string salt = AppEncryption.GenerateSalt();
            string hashedPassword = AppEncryption.CreatePassword(rawPassword, salt);


            var userMaster = new UserMaster
            {
                UserId = Guid.NewGuid(),
                UserName = model.UserName,
                Password = hashedPassword,
                Salt = salt,
                LoweredUserName = model.UserName.ToLower(),
                LastActivityDate = DateTimeOffset.UtcNow,
                LastLoginDate = DateTimeOffset.UtcNow,
                LastPasswordChangedDate = DateTimeOffset.UtcNow,
                LastLockoutDate = DateTimeOffset.UtcNow,
                PasswordFormat = 1,
                //CreatedBy = authUserId,
                ClientId = model.ClientId,
                FailedPasswordAttemptCount = 0,
                PasswordResetRequestActive = false,
                IsVerified = false,
                IsLockedOut = false,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                MobileNo=model.MobileNo,
            };

            var userAdded = await userRepository.AddUser(userMaster);
            if (userAdded <= 0)
            {
                return ApiResponse<UserMasterModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
            }


            var userRole = new UserRole
            {
                UserRoleId = Guid.NewGuid(),
                RoleId = model.RoleId,
                UserId = userMaster.UserId,
                ClientId = model.ClientId,
                //CreatedBy = model.ClientId,
                CreatedDate = DateTimeOffset.UtcNow
            };

            var userRoleAdded = await userRoleRepository.AddUserRole(userRole);
            if (userRoleAdded <= 0)
            {
                return ApiResponse<UserMasterModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
            }


            bool emailSent = await emailService.SendUserCredentialsEmailAsync(
                userMaster.UserName,
                userMaster.Name,
                rawPassword
            );

            if (!emailSent)
            {
                return ApiResponse<UserMasterModel>.ErrorResponse("Couldn't send Email. Please try again.", HttpStatusCodes.BadRequest);
            }


            var responseModel = new UserMasterModel
            {
                UserId = userMaster.UserId,
                UserName = userMaster.UserName,
                ClientId = userRole.ClientId,
                CreatedDate = userMaster.CreatedDate,
                LoweredUserName = userMaster.LoweredUserName,
                Name = userMaster.Name
            };

            return ApiResponse<UserMasterModel>.SuccessResponse(
                responseModel,
                ApiMessages.User.UserAddedSuccessfully,
                HttpStatusCodes.Created
            );
        }

        public Task<ApiResponse<bool>> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<IEnumerable<UserMasterResponseModel>>> GetAllUsers()
        {
            var users = await userRepository.GetAllUsers();
            if (users != null)
            {
                var res = users.Select(x => new UserMasterResponseModel
                {
                    UserId = x.UserId,
                    Name = x.Name,
                    UserName = x.UserName,
                    ClientName = x.Client != null ? x.Client.ClientName : string.Empty,
                    MobileNo = x.MobileNo,
                    ClientId = x.ClientId
                });
                return ApiResponse<IEnumerable<UserMasterResponseModel>>.SuccessResponse(res, $"{res.Count()} users fetched successfully.", HttpStatusCodes.OK);
            }
            return ApiResponse<IEnumerable<UserMasterResponseModel>>.ErrorResponse(ApiMessages.User.NoUserFound, HttpStatusCodes.BadRequest);

        }


        public async Task<ApiResponse<UserMasterModel>> GetUserById(Guid id)
        {
           var user=await userRepository.GetUserById(id);
            if(user != null)
            {
                return ApiResponse<UserMasterModel>.SuccessResponse(new UserMasterModel
                {
                    ClientId = user.UserId,
                    UserName = user.UserName,
                    Name = user.Name != null ? user.Name : "No User found",
                    MobileNo = user.MobileNo,

                }, ApiMessages.User.UserFound, HttpStatusCodes.OK);
            }
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<UserMasterResponseModel>> UpdateUser(UserMasterUpdateModel model)
        {
            try
            {
                var user = await userRepository.GetUserById(model.UserId);
                if (user is null)
                {
                    return ApiResponse<UserMasterResponseModel>.ErrorResponse("No nsuch User or Null", HttpStatusCodes.OK);
                }
                user.MobileNo = model.MobileNo;
                user.ModifiedBy = model.ModifiedBy;
                user.IsActive = model.IsActive ?? user.IsActive;

                var isUpdatedUser = await userRepository.UpdateUser(user);
                if (isUpdatedUser > 0)
                {
                    var res = new UserMasterResponseModel
                    {
                        UserId = user.UserId,
                        Name = user.Name,
                        MobileNo = model.MobileNo,
                        ModifiedBy = model.ModifiedBy,
                        IsActive = model.IsActive,
                        ClientId = user.ClientId,
                        UserName = user.UserName,
                        CreatedBy = user.CreatedBy,
                        CreatedDate = user.CreatedDate,
                    };
                    return ApiResponse<UserMasterResponseModel>.SuccessResponse(res, ApiMessages.User.UserUpdatedSuccessfully, HttpStatusCodes.OK);
                }
                return ApiResponse<UserMasterResponseModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
            }
            catch (Exception ex)
            {
                return ApiResponse<UserMasterResponseModel>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message}", HttpStatusCodes.BadRequest);
            }
        }





        }
    }
