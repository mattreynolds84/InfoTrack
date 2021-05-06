using System;
using System.Collections.Generic;
using System.Text;
using InfoTrack.DataAccess.Repositories;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;

namespace InfoTrack.Tests.RepositoryTests
{
    public class GoogleSearchRepositoryTests
    {
        private AutoMocker _mocker;
        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMocker();
        }

        [Test]
        public void GetResponse_Returns_Value()
        {
            var sut = _mocker.CreateInstance<GoogleSearchRepository>();
            var response = sut.GetResponse("efiling integration").Result;
            Assert.IsNotNull(response);
        }
    }
}
