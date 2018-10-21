
using Aplication.Enums;
using Bogus;
using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TengoFreeUnitTests.FakeData
{
   public static class TicketFakeData
    {

        public static List<Ticket> Tickets => new Faker<Ticket>().StrictMode(true)
                                                          .RuleFor(x => x.Area, f => f.PickRandom<TicketArea>())
                                                          .RuleFor(x => x.Id, f => Guid.NewGuid())
            .RuleFor(x => x.LastName, (f, x) => f.Name.LastName(Bogus.DataSets.Name.Gender.Male))
            .RuleFor(x => x.Name, (f, x) => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
            .RuleFor(x => x.Email, (f, x) => f.Internet.Email(x.Name, x.LastName))
            .RuleFor(x => x.Telephone, (f, x) => f.Person.Phone)
            .RuleFor(x => x.Description, (f, x) => f.Lorem.Sentence(250))
            .RuleFor(x => x.CreationDate, (f, x) => f.Date.Past(0))
            .RuleFor(x => x.Number, (f, x) => f.Random.Number(10000, 99999))
            .GenerateLazy(100).ToList();
        
    }
}
