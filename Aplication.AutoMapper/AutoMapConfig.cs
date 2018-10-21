using AutoMapper;

namespace Aplication.AutoMapper
{
    public class AutoMapConfig : Profile
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToDtoMappingProfile>();
                x.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
