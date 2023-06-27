namespace RecordManagementSystemInAxaNSamar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientBeneficiaries",
                c => new
                    {
                        ClientBeneficiaresId = c.Int(nullable: false, identity: true),
                        BFirstName = c.String(),
                        BMiddleName = c.String(),
                        BLastName = c.String(),
                        Birthday = c.String(),
                        BirthPlace = c.String(),
                        Relationship = c.String(),
                        Occupation = c.String(),
                        Share = c.Single(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientBeneficiaresId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        CLastName = c.String(),
                        CMiddleName = c.String(),
                        CFirstName = c.String(),
                        SpouseLastName = c.String(),
                        SpouseMiddleName = c.String(),
                        SpouseFirstName = c.String(),
                        Gender = c.String(),
                        CivilStatus = c.String(),
                        PolicyStatus = c.String(),
                        CBirthday = c.DateTime(nullable: false),
                        Age = c.String(),
                        PlaceOfBirth = c.String(),
                        Height = c.Single(nullable: false),
                        Weight = c.Single(nullable: false),
                        CAddress = c.String(),
                        CellphoneNo = c.String(),
                        TelephoneNo = c.String(),
                        EmailAddress = c.String(),
                        Occupation = c.String(),
                        WorkSalary = c.Single(nullable: false),
                        BusinessIncome = c.Single(nullable: false),
                        OtherSource = c.Single(nullable: false),
                        CompanyName = c.String(),
                        CompanyAddress = c.String(),
                        CompanyContact = c.String(),
                        NatureOfBusiness = c.String(),
                        TaxIdNumber = c.String(),
                        Sss_gsisNumber = c.String(),
                        ValidId1 = c.String(),
                        ValidId2 = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.ClientPlans",
                c => new
                    {
                        ClientPlanId = c.Int(nullable: false, identity: true),
                        PolicyNo = c.String(),
                        SumInsured = c.String(),
                        ModeOfPayment = c.String(),
                        DueOfPayment = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientPlanId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Plans", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.PlanId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        PlanName = c.String(),
                        PlanType = c.String(),
                        Category = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PlanId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        ELastName = c.String(),
                        EMiddleName = c.String(),
                        EFirstName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Age = c.String(),
                        EmailAddress = c.String(),
                        Gender = c.String(),
                        CivilStatus = c.String(),
                        CellphoneNo = c.String(),
                        Address = c.String(),
                        DesignatedPostion = c.String(),
                        IdPicture = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.PaymentRecords",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentPaid = c.Int(nullable: false),
                        PaidDate = c.DateTime(),
                        PolicyNumberPayment = c.String(),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                        UFirstName = c.String(),
                        UMiddleName = c.String(),
                        ULastName = c.String(),
                        UGender = c.String(),
                        ContactNumber = c.String(),
                        UAddress = c.String(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientBeneficiaries", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ClientPlans", "PlanId", "dbo.Plans");
            DropForeignKey("dbo.ClientPlans", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientPlans", new[] { "ClientId" });
            DropIndex("dbo.ClientPlans", new[] { "PlanId" });
            DropIndex("dbo.Clients", new[] { "EmployeeId" });
            DropIndex("dbo.ClientBeneficiaries", new[] { "ClientId" });
            DropTable("dbo.Users");
            DropTable("dbo.PaymentRecords");
            DropTable("dbo.Employees");
            DropTable("dbo.Plans");
            DropTable("dbo.ClientPlans");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientBeneficiaries");
        }
    }
}
