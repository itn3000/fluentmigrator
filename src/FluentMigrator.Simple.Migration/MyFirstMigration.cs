using System;

namespace FluentMigrator.Simple.Migration
{
    using FluentMigrator;
    [Migration(1)]
    public class MyFirstMigration : Migration
    {
        public override void Down()
        {
            Delete.Index("abc_index");
            Delete.Table("abc");
        }

        public override void Up()
        {
            Create.Table("abc")
                .WithColumn("moge").AsString(256).WithColumnDescription("moge column")
                ;
            Create.Index("abc_index").OnTable("abc").OnColumn("moge");
        }
    }
}
