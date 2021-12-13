
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/12/2021 13:15:28
-- Generated from EDMX file: D:\Visual Studio\Ex1\Ex1\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Dictionary];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DataSet'
CREATE TABLE [dbo].[DataSet] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [Surname] nvarchar(200)  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Patronymic] nvarchar(200)  NOT NULL,
    [Phonenumber] nvarchar(11)  NOT NULL,
    [DateBirth] datetime  NOT NULL,
    [Email] nvarchar(200)  NOT NULL,
    [Disable] bit  NOT NULL,
    [DisableDate] datetime  NULL,
    [DisableAuthor] nvarchar(400)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'DataSet'
ALTER TABLE [dbo].[DataSet]
ADD CONSTRAINT [PK_DataSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------