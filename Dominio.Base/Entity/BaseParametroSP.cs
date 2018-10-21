using System.Data;

namespace Domain.Base.Entity
{
    public class BaseParameterSp
    {
        public string Name { get; set; }
        public DbType ParameterType { get; set; }
        public object Value { get; set; }
        public ParameterDirection Direction { get; set; }
    }
}
