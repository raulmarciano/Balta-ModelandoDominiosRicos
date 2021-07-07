using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWHenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Kyaslo";
            command.LastName = "Rennf";
            command.Document = "9999999999";
            command.Email = "hello@balta.io";

            command.BarCode = "2125554542121215";
            command.BoletoNumber = "12121212";

            command.PaymentNumber = "2151";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Star Wars";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "kylo@star.com";

            command.Street = "aaa";
            command.Number = "sss";
            command.Neighbothood = "ddd";
            command.City = "www";
            command.State = "jjj";
            command.Country = "lll";
            command.ZipCode = "qqq";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}