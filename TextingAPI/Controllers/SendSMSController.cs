using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TextingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SendSMSController : ControllerBase
    {
        string accountSid = "";
        string authToken = "";

        [HttpPost("SendText")]
        public ActionResult SendText(string phoneNumber)
        {

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hi To Youtube from my .Net 6 API Using Twilio",
                from: new Twilio.Types.PhoneNumber("+18315259256"),
                to: new Twilio.Types.PhoneNumber("+1" + phoneNumber)
            );

            Console.WriteLine(message.Sid);

            return StatusCode(200, new { message = message.Sid });

        }
    }
}
