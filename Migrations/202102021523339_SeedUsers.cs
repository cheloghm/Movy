namespace Movy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4a26579d-c766-4a93-939a-c3f030fa6663', N'guest@movy.com', 0, N'AFUBIGmLFCdo3beSus6uyS5oq8485Nm9qWvC+bKYEAi7DzTVRBUvVemP3vwDiPwNxw==', N'd5d15e9a-7d60-44f8-ae26-0b18a21021da', NULL, 0, 0, NULL, 1, 0, N'guest@movy.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'afd3c06d-6c0d-4470-932f-1c5174e8cedb', N'admin@movy.com', 0, N'ANzG8o/Z6h0v8Y/DsX7wgU1VrMUrSvp4uFkS07UK3MZLYkYHyw9jolMhcWCXpZVCzw==', N'7c02840d-4d9a-4d7d-b669-cb3aef317efc', NULL, 0, 0, NULL, 1, 0, N'admin@movy.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2f67be19-27af-43fb-9002-dc442930b9f2', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'afd3c06d-6c0d-4470-932f-1c5174e8cedb', N'2f67be19-27af-43fb-9002-dc442930b9f2')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
