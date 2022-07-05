USE [C:\USERS\2190785\DOCUMENTS\GITREPO\ATM_MANAGEMENT\ATM\ATM_DB.MDF]
GO

/****** Object: Table [dbo].[Users] Script Date: 01/07/2022 20:42:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (20) NOT NULL,
    [Email]         NVARCHAR (50) NOT NULL,
    [Username]      NVARCHAR (50) NOT NULL,
    [Password]      NVARCHAR (50) NOT NULL,
    [Balance]       DECIMAL (18)  NOT NULL,
    [AccountNumber] INT           NOT NULL
);


