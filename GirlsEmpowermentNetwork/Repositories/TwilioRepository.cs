using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace GirlsEmpowermentNetwork.Repositories
{
    public class TwilioRepository
    {
        public TwilioRepository()
        {
            string accountSid = "AC0abd5864436bc8d6c9f5389bd377c850";
            const string authToken = "179df7a6c00d4045ab4afbac8beef23e";

            TwilioClient.Init(accountSid, authToken);
        }

        public async Task<MessageResource.StatusEnum> SendAsync(string MessageBody, string ToPhoneNumber, string FromPhoneNumber= "+15125184414")
        {
            var message = await MessageResource.CreateAsync(
                body: MessageBody,
                from: new PhoneNumber(FromPhoneNumber),
                to: new PhoneNumber(ToPhoneNumber));

            return message.Status;
        }
    }
}
