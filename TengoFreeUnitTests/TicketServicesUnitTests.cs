using Services.Core.Ticket.DTOs;
using Domain.Base.Repository;
using Domain.Base.UnitOfWork;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Core.Ticket;
using System;
using TengoFreeUnitTests.FakeData;
using System.Collections.Generic;

namespace TengoFreeUnitTests
{
    [TestClass]
    public class TicketServicesUnitTests
    {
        Mock<IRepository<Domain.Core.Ticket>> _ticketRepository;
        Mock<IUnitOfWork> _uow;
        public TicketServicesUnitTests()
        {
            _ticketRepository = new Mock<IRepository<Domain.Core.Ticket>>();
            _uow=new Mock<IUnitOfWork>();
            _ticketRepository.Setup(x => x.GetAll(It.IsAny<string>())).Returns(TicketFakeData.Tickets);
            _ticketRepository.Setup(x => x.GetById(It.IsAny<Guid>(), It.IsAny<string>())).Returns(new Domain.Core.Ticket
            {
                Id = Guid.NewGuid(),
                Name = "Santiago",
                LastName = "Arias",
                Area = Aplication.Enums.TicketArea.Otros,
                Description = "Una descripcion de ticket",
                CreationDate = DateTime.Now,
                Email = "sna1988@gmail.com",
                Number = 12345,
                Telephone = "154187286"

            });
        }

        [TestMethod]
        public void Create_ValidTicketParameters_ValidTicketCreateDto()
        {
            
            
            
           

            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object);

            // Testing Valid Values
            var response = ticketServices.Create("Santiago", "Arias", Aplication.Enums.TicketArea.Administracion, "154187286", "sna1988@gmail.com", "La drecripción del ticket tiene que ir en este lugar.");
            response.Should().NotBeNull();
            response.Name.Should().Be("Santiago");
            response.LastName.Should().Be("Arias");
            response.Area.Should().Be(Aplication.Enums.TicketArea.Administracion);
            response.Telephone.Should().Be("154187286");
            response.Email.Should().Be("sna1988@gmail.com");
            response.CreationDate.Should().BeCloseTo(DateTime.Now, 5000);
            response.Number.Should().BeGreaterThan(9999);

        }

        [TestMethod]
        public void CreateTicketNumber_ExpectValidTicketNumber()
        {
              
                  
            


            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object);

            // Testing Valid Values
            var response = ticketServices.CreateTicketNumber();

            response.Should().BeGreaterThan(9999);
            

        }

        [TestMethod]
        public void GetTickets_ExpectListOfTicketListDto()
        {


            

            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object);
            var response = ticketServices.GetTickets();
            
            response.Should().HaveCountGreaterThan(1);
            

        }

        [TestMethod]
        public void GetTicketById_ValidTicketId_ExpectValidTicketDto()
        {


            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object);

            var response = ticketServices.GetTicketById(Guid.NewGuid());
            response.Should().BeOfType(typeof(Services.Core.Ticket.DTOs.TicketDto));
            response.Should().NotBeNull();
            response.Id.Should().NotBeNull();
            response.Name.Should().Be("Santiago");
            
        }


      
    }
}
