USE [Ayo]
GO

/****** Object:  Table [dbo].[Unit]    Script Date: 2019/04/14 8:38:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL,
CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED ([Id] ASC)
GO

insert [dbo].[Category]
Values('Length')
,('Temperature')
,('Mass')
,('Volume')
,('Force')
,('Pressure')
,('Velocity')
,('Power')
,('Torque')
,('Fuel Economy')
,('Engine Capacity')
,('Vacuum')

CREATE TABLE [dbo].[ConversionChart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Metric] [varchar](25) NOT NULL,
	[Imperial] [varchar](25) NOT NULL,
	[CategoryId] [int] NOT NULL,
	CONSTRAINT [PK_ConversionChart] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_ConversionChart_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category]([Id])
	)

GO

insert[dbo].[ConversionChart]
values ('millimetre', 'Inch', (select Id from [dbo].[Category] where [Name] = 'Length'))
,('metre', 'foot', (select Id from [dbo].[Category] where [Name] = 'Length'))
,('kilometer', 'mile', (select Id from [dbo].[Category] where [Name] = 'Length'))

