using AbpCompanyName.AbpProjectName.Something;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AbpCompanyName.AbpProjectName.Tests
{
    public class DependencyInjectionTests : AbpProjectNameTestBase
    {
        [Fact]
        public void ShouldBeRepalced()
        {
            LocalIocManager.Resolve<ISomething>().ShouldBeOfType<MockSomething>();
        }
    }
}
