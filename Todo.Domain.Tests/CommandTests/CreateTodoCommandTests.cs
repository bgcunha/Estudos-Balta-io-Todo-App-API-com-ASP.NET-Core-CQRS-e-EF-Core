using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
       private readonly CreateTodoCommand _Invalidcommand = new CreateTodoCommand("", "", DateTime.Now);
       private readonly CreateTodoCommand _Validcommand = new CreateTodoCommand("Ir ao mercado", "Bruno Gomes", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _Invalidcommand.Validate();
            _Validcommand.Validate();

        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_Invalidcommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_Validcommand.Valid, true);
        }
    }
}
