using StructureMap;

namespace Aplication.IoC
{
    public class StructureMapFilterProvider
    {
        private readonly IContainer container;
        public StructureMapFilterProvider(IContainer container)
        {
            this.container = container;
        }
    }
}
