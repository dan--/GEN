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
        public async Task SendAsync_ShouldCorrectlyText()
        {
            //arrange
            var response = await twilioRepository.SendAsync("this is a test text", "+12142408305");

            //assert
            response.ShouldNotBeNull();
            response.ShouldBe(MessageResource.StatusEnum.Delivered);
        }
    }
}
