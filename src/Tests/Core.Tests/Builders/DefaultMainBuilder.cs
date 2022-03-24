using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DI.Builders;
using DI.Core.Tests.Fixtures;

using Moq;

using Xunit;

namespace DI.Core.Tests.Builders
{
    public class DefaultMainBuilder
    {
        [Fact]
        public void RegisterDependencies_ShouldInvokeAction()
        {
            var list = Mock.Of<IList<Type>>();
            var register = new DependenciesRegister<ExampleDefaultBuilder>(list);

            var builder = new ExampleDefaultMainBuilder();

            var actionMock = new Mock<Action<DependenciesRegister<ExampleDefaultBuilder>>>();
            actionMock.Setup(mocked => mocked.Invoke(It.IsNotNull<DependenciesRegister<ExampleDefaultBuilder>>()));

            var result = builder.InvokeRegisterDependencies(actionMock.Object);

            Assert.True(ReferenceEquals(builder, result));
            
            actionMock.Verify(mocked => mocked.Invoke(It.IsNotNull<DependenciesRegister<ExampleDefaultBuilder>>()));
        }
    }
}
