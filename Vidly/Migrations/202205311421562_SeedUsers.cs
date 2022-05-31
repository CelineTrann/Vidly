namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'92c07e9e-2686-4476-aaf6-2bd005592dd3', N'admin@vidly.com', 0, N'ALEFbNYBN+OjPBSi+HSfgIsvCi1zVlcoVBwW+ux4WR/wbHPUmk+0ObF+tfMk4eUuYA==', N'54762df2-2c23-4095-905c-a8e6d4268949', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e274b8dc-1d4a-4b77-92e6-e18912fbee70', N'guest@vidly.com', 0, N'AFZFs9K7dtzBNWsq6ty8iYiC6r7MZkaC+voCM5PiaAY4YkbIvlF5DVrSfhtzvJWvWA==', N'b483fa62-f96d-40d1-985c-f181005391d1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'94abb5bd-da97-471b-b7f0-a5cebc78f923', N'CanManageMovie')
       
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'92c07e9e-2686-4476-aaf6-2bd005592dd3', N'94abb5bd-da97-471b-b7f0-a5cebc78f923')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
