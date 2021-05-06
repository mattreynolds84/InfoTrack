using InfoTrack.BusinessLogic.Services;
using InfoTrack.DataAccess.Repositories;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InfoTrack.Tests.ServiceTests
{
    public class GoogleSearchServiceTests
    {
        private AutoMocker _mocker;
        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMocker();
        }

        [Test]
        public void Search_Returns_2_Results()
        {
            string responseString;
            using (var stream = this.GetType().Assembly.GetManifestResourceStream("InfoTrack.Tests.Samples.searchResults.html"))
            {
                using (var reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            var repo = _mocker.GetMock<IGoogleSearchRepository>();
            repo.Setup(x => x.GetResponse(It.IsAny<string>())).ReturnsAsync(responseString);
            var sut = _mocker.CreateInstance<GoogleSearchService>();

            var results = sut.Search("efiling integration", "infotrack.com").Result;
            
            Assert.True(results.Count() == 1);
            Assert.True(results.First() == 3);
        }
    }
}
