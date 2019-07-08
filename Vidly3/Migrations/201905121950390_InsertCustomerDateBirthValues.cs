namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCustomerDateBirthValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = 01/05/1980 WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = 09/30/1993 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
