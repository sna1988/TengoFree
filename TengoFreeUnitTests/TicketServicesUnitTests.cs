using Domain.Base.Repository;
using Domain.Base.UnitOfWork;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Core.Ticket;
using System;
using TengoFreeUnitTests.FakeData;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace TengoFreeUnitTests
{
    [TestClass]
    public class TicketServicesUnitTests
    {
        Mock<IRepository<Domain.Core.Ticket>> _ticketRepository;
        Mock<IUnitOfWork> _uow;
        Mock<IMapper> _mapper;


        public TicketServicesUnitTests()
        {
            _ticketRepository = new Mock<IRepository<Domain.Core.Ticket>>();
            _uow=new Mock<IUnitOfWork>();
            _mapper = new Mock<IMapper>();

            

          

            _ticketRepository.Setup(x => x.GetAll(It.IsAny<string>())).Returns(TicketFakeData.Tickets);

           
        }

        [TestMethod]
        public void Create_ValidTicketParameters_ValidTicketCreateDto()
        {

            _mapper.Setup(x => x.Map<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketCreateDto>(It.IsAny<Domain.Core.Ticket>()))
       .Returns(new DataTransferObjects.Ticket.TicketCreateDto()
       {
           Name = "Santiago",
           LastName = "Arias",
           Area=Aplication.Enums.TicketArea.Administracion,
           Email="sna1988@gmail.com",
           CreationDate=DateTime.Now,
           Number=15485,
           Description= "La drecripción del ticket tiene que ir en este lugar.",
           Telephone= "154187286",

       });



            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object,_mapper.Object);

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


         

            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object,_mapper.Object);

            // Testing Valid Values
            var response = ticketServices.CreateTicketNumber();

            response.Should().BeGreaterThan(9999);
            

        }

        [TestMethod]
        public void GetTickets_ExpectListOfTicketListDto()
        {



            _mapper.Setup(x => x.Map<IEnumerable<Domain.Core.Ticket>, IEnumerable<DataTransferObjects.Ticket.TicketListDto>>(It.IsAny<List<Domain.Core.Ticket>>())).Returns(TicketFakeData.Tickets.Select(x => new DataTransferObjects.Ticket.TicketListDto()
            {
                CreationDate = x.CreationDate,
                Description = x.Description,
                Email = x.Email,
                Id = x.Id,
                LastName = x.LastName,
                Name = x.Name,
                Number = x.Number,
                Telephone = x.Telephone,
                TicketArea = x.Area
            }).ToList());

            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object,_mapper.Object);
            var response = ticketServices.GetTickets();
            
            response.Should().HaveCountGreaterThan(1);
            

        }

        [TestMethod]
        public void GetTicketById_ValidTicketId_ExpectValidTicketDto()
        {
            var ticketReturned = new Domain.Core.Ticket
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

            };

            var ticketDto = new DataTransferObjects.Ticket.TicketDto()
            {
                Id=ticketReturned.Id,
                Name=ticketReturned.Name,
                LastName=ticketReturned.LastName,
                CreationDate=ticketReturned.CreationDate,
                Description=ticketReturned.Description,
                TicketArea=ticketReturned.Area,
                Email=ticketReturned.Email,
                Number=ticketReturned.Number,
                Telephone=ticketReturned.Telephone

            };

            _mapper.Setup(x => x.Map<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketDto>(It.IsAny<Domain.Core.Ticket>()))
       .Returns(ticketDto);
            _ticketRepository.Setup(x => x.GetById(It.IsAny<Guid>(), It.IsAny<string>())).Returns(ticketReturned);
            var ticketServices = new TicketServices(_ticketRepository.Object, _uow.Object,_mapper.Object);

            var response = ticketServices.GetTicketById(Guid.NewGuid());
            response.Should().BeOfType(typeof(DataTransferObjects.Ticket.TicketDto));
            response.Should().NotBeNull();
            response.Id.Should().NotBeNull();
            response.Name.Should().Be("Santiago");
            
        }


      
    }
}
