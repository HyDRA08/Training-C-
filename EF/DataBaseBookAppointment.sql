USE [Trainee1334]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 14-08-2019 19:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[ApptID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [varchar](255) NULL,
	[EmpID] [int] NULL,
	[HRID] [int] NULL,
	[Slot] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ApptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 14-08-2019 19:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DeptID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 14-08-2019 19:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [varchar](255) NOT NULL,
	[Email] [varchar](255) NULL,
	[DeptID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holiday]    Script Date: 14-08-2019 19:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday](
	[HolidayID] [int] IDENTITY(1,1) NOT NULL,
	[HolidayDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[HolidayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slot]    Script Date: 14-08-2019 19:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[SlotID] [int] IDENTITY(1,1) NOT NULL,
	[SlotTime] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 
GO
INSERT [dbo].[Department] ([DeptID], [DepartmentName]) VALUES (1, N'HR')
GO
INSERT [dbo].[Department] ([DeptID], [DepartmentName]) VALUES (2, N'Accounts')
GO
INSERT [dbo].[Department] ([DeptID], [DepartmentName]) VALUES (3, N'Marketing')
GO
INSERT [dbo].[Department] ([DeptID], [DepartmentName]) VALUES (4, N'Developing')
GO
INSERT [dbo].[Department] ([DeptID], [DepartmentName]) VALUES (5, N'Infrastructure')
GO
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (1, N'Mathew', N'mathew@qburst.com', 2)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (2, N'Anirudh', N'anirudh@qburst.com', 3)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (4, N'Merin', N'merin@qburst.com', 2)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (5, N'Hari', N'hari@qburst.com', 4)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (6, N'Shijo', N'shijo@qburst.com', 4)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (7, N'Paul', N'paul@qburst.com', 1)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (8, N'Kiran', N'kiran@qburst.com', 1)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Email], [DeptID]) VALUES (9, N'Anju', N'anju@qburst.com', 1)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Holiday] ON 
GO
INSERT [dbo].[Holiday] ([HolidayID], [HolidayDate]) VALUES (9, CAST(N'2019-08-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Holiday] ([HolidayID], [HolidayDate]) VALUES (10, CAST(N'2019-09-09T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Holiday] OFF
GO
SET IDENTITY_INSERT [dbo].[Slot] ON 
GO
INSERT [dbo].[Slot] ([SlotID], [SlotTime]) VALUES (1, N'10.00 - 10.30')
GO
INSERT [dbo].[Slot] ([SlotID], [SlotTime]) VALUES (2, N'10.30 - 11.00')
GO
INSERT [dbo].[Slot] ([SlotID], [SlotTime]) VALUES (3, N'11.00 - 11.30')
GO
INSERT [dbo].[Slot] ([SlotID], [SlotTime]) VALUES (4, N'11.30 - 12.00')
GO
SET IDENTITY_INSERT [dbo].[Slot] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UCE_Email]    Script Date: 14-08-2019 19:51:59 ******/
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [UCE_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([HRID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptID])
REFERENCES [dbo].[Department] ([DeptID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptID])
REFERENCES [dbo].[Department] ([DeptID])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([AppointmentDate]<>'2019-08-01'))
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([Slot]='11.30 - 12.00' OR [Slot]='11.00 - 11.30' OR [Slot]='10.30 - 11.00' OR [Slot]='10.00 - 10.30'))
GO
