using NUnit.Framework;
using Banco;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Constructor()
        {
            //Arranque
            Cuenta c = new Cuenta();
            double resultado;

            //Acci�n
            resultado = c.SaldoActual;

            //Aseveraci�n
            Assert.IsNotNull(resultado);
        }

        [Test]
        public void Test_getBalance()
        {
            //Arranque
            Cuenta c = new Cuenta();
            double resultado;
            c.SaldoActual = 12.1;

            //Acci�n
            resultado = c.getBalance();

            //Aseveraci�n
            Assert.AreEqual(resultado,12.1);
        }


        [Test]
        public void Test_deposit1()
        {
            //Arranque
            Cuenta c = new Cuenta();

            //Acci�n
            c.deposit(1.1);

            //Aseveraci�n
            Assert.AreEqual(1.1, c.SaldoActual);
        }

        [Test]
        public void Test_deposit2()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12.2;

            //Acci�n
            c.deposit(1.1);

            //Aseveraci�n
            Assert.AreEqual(13.3, c.SaldoActual);
        }


        [Test]
        public void Test_retirarFondos1()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12;

            //Acci�n
            c.withdraw(1.1);

            //Aseveraci�n
            Assert.AreEqual(10.9, c.SaldoActual);
        }

        [Test]
        public void Test_retirar0()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12;

            //Acci�n
            c.withdraw(0);

            //Aseveraci�n
            Assert.AreEqual(12, c.SaldoActual);
        }

        [Test]
        public void Test_ToString()
        {
            //Arranque
            Cuenta c = new Cuenta();
            string s;
            c.SaldoActual = 12;

            //Acci�n
            s = c.ToString();

            //Aseveraci�n
            Assert.AreEqual("12", s);
        }
    }
}