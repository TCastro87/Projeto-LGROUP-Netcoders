using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using System.Linq;

namespace Test
{
    
    [TestClass]
    public class ContatoTest
    {
        private readonly ContatoRepository _repository;

        public ContatoTest()
        {
            _repository = new ContatoRepository();
        }

        [TestInitialize]
        public void Comeca()
        {
            Console.WriteLine("af.kub");
        }


        [TestMethod]
        public void ExisteContato()
        {
            var list = _repository.GetAll();

            // se a lista estiver vazia, lançar falhar
            //if (!list.Any()) Assert.Fail();

            var qtdeEsperada = 4;

            ///Assert.IsTrue(list.Count() == qtdeEsperada);
        }

    }
}
