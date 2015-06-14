USE [CityCountryDB]
GO
SET IDENTITY_INSERT [dbo].[tblCountry] ON 

INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (1, N'Bangladesh', N'Bangladesh is an independent country But it has a large population . It''s a democratic country')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (2, N'Pakistan', N'Jongider desh')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (10, N'India', N'erkfje')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (12, N'Maldip', N'Small Country')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (13, N'China', N'It has a large economy')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (14, N'Japan', N'Situated in ASIA')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (16, N'Mayanmar', N'Terrorist')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (17, N'', N'')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (18, N'England', N'It''s a Europe country')
INSERT [dbo].[tblCountry] ([id], [countryName], [about]) VALUES (19, N'USA', N'It''s a terrorist country')
SET IDENTITY_INSERT [dbo].[tblCountry] OFF
SET IDENTITY_INSERT [dbo].[tblCity] ON 

INSERT [dbo].[tblCity] ([id], [cityName], [about], [numberOfDwellers], [location], [weather], [countryID]) VALUES (1, N'Dhaka', N'Capital of Bangladesh', 1234, N'southest region of Bangladesh', N'Moderate', 1)
INSERT [dbo].[tblCity] ([id], [cityName], [about], [numberOfDwellers], [location], [weather], [countryID]) VALUES (2, N'Sylhet', N'City of peace in Bangladesh', 103455, N'north-east region of Bangladesh', N'Moderate', 1)
INSERT [dbo].[tblCity] ([id], [cityName], [about], [numberOfDwellers], [location], [weather], [countryID]) VALUES (3, N'Mombai', N'City of commerce in India ', 12345680, N'Center of India', N'Moderate', 10)
SET IDENTITY_INSERT [dbo].[tblCity] OFF
