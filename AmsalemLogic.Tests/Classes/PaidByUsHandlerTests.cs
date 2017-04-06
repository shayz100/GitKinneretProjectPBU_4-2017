using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmsalemLogic.NewLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmsalemLogic.NewLogic.Classes.Tests
{
    [TestClass()]
    public class PaidByUsHandlerTests
    {
        [TestMethod()]
        public void ApllyGetCardAlgorithmPubicTest()
        {
            var handler = new PaidByUsHandler();
            var transaction = new PaidByUsTransaction()
            {
                CurrencyCode = "EUR"
            };
            var card = handler.ApllyGetCardAlgorithmPubic(1332, transaction);
            Assert.IsNotNull(card);
            transaction = new PaidByUsTransaction()
            {
                CurrencyCode = "USD"
            };
            card = handler.ApllyGetCardAlgorithmPubic(1332, transaction);
            Assert.IsNotNull(card);
        }
    }
}