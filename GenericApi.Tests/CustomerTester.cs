using GenericAPI.Models;
using GenericAPI.Repository.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericApi.Tests
{
    public class CustomerTester
    {
        private Mock<IGenericRepository<Customer>> customerRepository;
        private List<Customer> customersList;
        [SetUp]
        public void Setup()
        {
            customerRepository = new Mock<IGenericRepository<Customer>>();
            customersList = new List<Customer>();
            var Now = DateTime.Now;
            customersList.Add(new Customer() { FirstName = "Meseret", LastName = "Kassaye", EmailAddress = "meseret.kassaye@gmail.com", Phone = "0923644545",CreateOn=Now,UpdateOn=Now });
            customersList.Add(new Customer() { FirstName = "Mahder", LastName = "Girma", EmailAddress = "mahder.girma@gmail.com", Phone = "0913044626", CreateOn = Now, UpdateOn = Now });
        }

        [Test]
        public void Test1()
        {
            //Act
            customerRepository.Setup(c => c.GetAll()).Returns(customersList.AsQueryable());

            //Arrange
            var customer = new CustomerBL(customerRepository.Object);
            var CustomeList = customer.GetAllCustomer();

            //Assert
            Assert.IsTrue(CustomeList.Count == 2);
            Assert.IsTrue(customersList.Find(c=>c.Phone=="0923644545").FirstName=="Meseret");
        }

        [Test]
        public void Check_Customer_Phone_IsNotNull()
        {
            //Arrange
            var customer = new CustomerBL(customerRepository.Object);
            var CustomeList = customer.GetAllCustomer();

            //Assert
            Assert.IsTrue(customersList.All(c => c.Phone != null));

        }
    }

   
}