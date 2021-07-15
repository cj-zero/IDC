using IDC.Application;
using IDC.Application.Common;
using IDC.Repository.Dapper;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using IDC.Repository.Entities.NsapBase;

namespace NUnitTestIDC
{
    [TestFixture]
    public class TestApi
    {
        private  IRepositoryBase _repositoryBase;
        [SetUp]
        public void Setup()
        {
            _repositoryBase = new Mock<IRepositoryBase>().Object;
        }
        [Test]
        public async Task Test1()
        {
        }
    }
}