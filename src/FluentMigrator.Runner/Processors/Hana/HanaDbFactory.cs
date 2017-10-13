using System.Data.Common;

namespace FluentMigrator.Runner.Processors.Hana
{
    public class HanaDbFactory : DbFactoryBase
    {
        protected override DbProviderFactory CreateFactory()
        {
            #if NET451
            return DbProviderFactories.GetFactory("Sap.Data.Hana");
            #else
            throw new System.NotSupportedException("not supported in netstandard2.0");
            #endif
        }
    }
}