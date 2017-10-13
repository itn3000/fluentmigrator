namespace FluentMigrator.Runner.Processors
{
    using System;
    using System.Data.Common;
    using System.Reflection;

    public class ReflectionBasedDbFactory : DbFactoryBase
    {
        private readonly string assemblyName;
        private readonly string dbProviderFactoryTypeName;

        public ReflectionBasedDbFactory(string assemblyName, string dbProviderFactoryTypeName)
        {
            this.assemblyName = assemblyName;
            this.dbProviderFactoryTypeName = dbProviderFactoryTypeName;
        }

        protected override DbProviderFactory CreateFactory()
        {
            return (DbProviderFactory)Assembly.Load(assemblyName).CreateInstance(dbProviderFactoryTypeName);
            // return (DbProviderFactory)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(assemblyName, dbProviderFactoryTypeName);
        }
    }
}