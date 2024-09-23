using System.Threading.Tasks;
using Ocean.Labs.Models.TokenAuth;
using Ocean.Labs.Web.Controllers;
using Shouldly;
using Xunit;

namespace Ocean.Labs.Web.Tests.Controllers
{
    public class HomeController_Tests: LabsWebTestBase
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