using System.Threading.Tasks;
using MonkeyAndRiver.Models.TokenAuth;
using MonkeyAndRiver.Web.Controllers;
using Shouldly;
using Xunit;

namespace MonkeyAndRiver.Web.Tests.Controllers
{
    public class HomeController_Tests: MonkeyAndRiverWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}