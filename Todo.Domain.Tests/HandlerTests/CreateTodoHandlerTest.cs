using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTest
    {
        private readonly CreateTodoCommand _invalidcommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validcommand = new CreateTodoCommand("Ir ao mercado", "Bruno Gomes", DateTime.Now);
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());

        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidcommand);

            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            _result = (GenericCommandResult)_handler.Handle(_validcommand);

            Assert.AreEqual(_result.Success, true);            
        }
    }
}
