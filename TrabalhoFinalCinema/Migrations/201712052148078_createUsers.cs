namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'6b7f2a51-b978-414b-b459-54e7a17f0c3e', N'julia.nascimento@catolicasc.org.br', 0, N'ALcf9W/Pz9b5pHNW/ozQ4rKhw4caaFMzjkBvwhiAbtoDmfauQHM6K5SswMIczTPbCw==', N'8f6b04b9-dbd0-425b-a482-463da4bab4fc', NULL, 0, 0, NULL, 1, 0, N'julia.nascimento@catolicasc.org.br')
INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'cac9560c-01b4-47a6-919d-11adb8032bec', N'juliasn14@gmail.com', 0, N'AKFZg3b8x/jx5YDwuq+6wdsL1rTFyHKNFpB1mxVYsVbEVt4RmoRosvgWIcRaYDAAPg==', N'b5e4a9a2-1ff1-4f9f-9ed3-6fcc33eeb6eb', NULL, 0, 0, NULL, 1, 0, N'juliasn14@gmail.com')
");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (NULL, NULL)");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (NULL, NULL)");
        }

    public override void Down()
        {
        }
    }
}
