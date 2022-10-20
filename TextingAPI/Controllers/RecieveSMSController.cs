using Microsoft.AspNetCore.Mvc;
using TextingAPI.Models;
using Twilio;
using Twilio.AspNet.Core;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
using Twilio.Types;

namespace TextingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecieveSMSController : TwilioController
    {

        [HttpPost("SendReply")]
        public TwiMLResult SendReply([FromForm] TwilioSMS request)
        {
            var response = new MessagingResponse();
            response.Message("This is me replying from the API, SUP YOUTUBE!");

            return TwiML(response);

        }
    }
}
