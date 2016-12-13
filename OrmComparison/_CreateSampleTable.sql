

/****** Object:  Table [dbo].[Campaign]    Script Date: 10/12/2016 8:23:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Campaign](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CampaignImpactId] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[EndDateTime] [datetimeoffset](7) NOT NULL,
	[ExternalUrl] [nvarchar](max) NULL,
	[ExternalUrlText] [nvarchar](max) NULL,
	[Featured] [bit] NOT NULL,
	[FullDescription] [nvarchar](max) NULL,
	[Headline] [nvarchar](150) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[LocationId] [int] NULL,
	[Locked] [bit] NOT NULL,
	[ManagingOrganizationId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[OrganizerId] [nvarchar](450) NULL,
	[StartDateTime] [datetimeoffset](7) NOT NULL,
	[TimeZoneId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Campaign] ON 

GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (1, NULL, NULL, CAST(N'2017-02-07T17:00:58.0643043-06:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 1, 0, 1, N'Neighborhood Fire Prevention Days', NULL, CAST(N'2016-10-07T17:00:58.0592905-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (2, 1, NULL, CAST(N'2016-12-07T00:00:00.0000000-06:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 12, 0, 1, N'Working Smoke Detectors Save Lives', NULL, CAST(N'2016-10-07T00:00:00.0000000-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (3, NULL, NULL, CAST(N'2016-12-07T00:00:00.0000000-06:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 12, 0, 1, N'Everyday Financial Safety', NULL, CAST(N'2016-10-07T00:00:00.0000000-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (4, NULL, NULL, CAST(N'2017-01-07T00:00:00.0000000-06:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 12, 0, 1, N'Simple Safety Kit Building', NULL, CAST(N'2016-10-07T00:00:00.0000000-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (5, NULL, NULL, CAST(N'2017-01-07T00:00:00.0000000-06:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 12, 0, 1, N'Family Safety In the Car', NULL, CAST(N'2016-10-07T00:00:00.0000000-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
INSERT [dbo].[Campaign] ([Id], [CampaignImpactId], [Description], [EndDateTime], [ExternalUrl], [ExternalUrlText], [Featured], [FullDescription], [Headline], [ImageUrl], [LocationId], [Locked], [ManagingOrganizationId], [Name], [OrganizerId], [StartDateTime], [TimeZoneId]) VALUES (6, NULL, NULL, CAST(N'2017-05-07T00:00:00.0000000-05:00' AS DateTimeOffset), NULL, NULL, 0, NULL, NULL, NULL, 12, 0, 1, N'Be Ready to Get Out: Have a Home Escape Plan', NULL, CAST(N'2016-05-07T00:00:00.0000000-05:00' AS DateTimeOffset), N'Central Standard Time')
GO
SET IDENTITY_INSERT [dbo].[Campaign] OFF
GO