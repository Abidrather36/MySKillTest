//using Microsoft.Owin.Security.Infrastructure;
//using Microsoft.Owin.Security.OAuth;
//using System;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace OSAP.WebApi.Models
//{
//    public class RefreshTokenProvider : AuthenticationTokenProvider
//    {
//        public override void Create(AuthenticationTokenCreateContext context)
//        {
//            // Expiration time in seconds
//            //int expire = 5 * 60;
//            context.Ticket.Properties.ExpiresUtc = new DateTimeOffset(DateTime.Now.AddDays(1));
//            context.SetToken(context.SerializeTicket());
//        }

//        public override void Receive(AuthenticationTokenReceiveContext context)
//        {
//            context.DeserializeTicket(context.Token);
//        }
//    }
//}