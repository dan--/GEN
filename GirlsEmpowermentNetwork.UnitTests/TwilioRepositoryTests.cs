using GirlsEmpowermentNetwork.Repositories;
using Shouldly;
using System;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;
using Xunit;

namespace GirlsEmpowermentNetwork.IntegrationTests
{
    public class TwilioRepositoryTests
    {
        private readonly TwilioRepository twilioRepository;

        public TwilioRepositoryTests()
        {
            twilioRepository = new TwilioRepository();
        }

        [Fact]
        public void SendAsync_ShouldCorrectlySendAText()
        {
            //arrange
            var response = twilioRepository.Send("this is a test text", "+1214240-8305");

            //assert
            response.ShouldNotBeNull();
            response.ShouldNotBe(MessageResource.StatusEnum.Failed);
            response.ShouldNotBe(MessageResource.StatusEnum.Undelivered);
        }
    }
}
