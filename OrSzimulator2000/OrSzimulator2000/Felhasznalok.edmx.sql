
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2018 21:04:55
-- Generated from EDMX file: C:\Users\Ian\Documents\github\vizprog\vizprog\OrSzimulator2000\OrSzimulator2000\Felhasznalok.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Adatbazis];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Felhasznalok]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Felhasznalok];
GO
IF OBJECT_ID(N'[dbo].[Karakterek]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Karakterek];
GO
IF OBJECT_ID(N'[dbo].[Lakhely]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lakhely];
GO
IF OBJECT_ID(N'[dbo].[Szornyek]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Szornyek];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Felhasznalok'
CREATE TABLE [dbo].[Felhasznalok] (
    [Felhasznalonev] varchar(50)  NOT NULL,
    [Jelszo] varchar(50)  NULL
);
GO

-- Creating table 'Karakterek'
CREATE TABLE [dbo].[Karakterek] (
    [KarakterId] int IDENTITY(1,1) NOT NULL,
    [Nev] nvarchar(max)  NOT NULL,
    [Tamadas] int  NOT NULL,
    [Vedes] int  NOT NULL
);
GO

-- Creating table 'Lakhely'
CREATE TABLE [dbo].[Lakhely] (
    [LakhelyId] int IDENTITY(1,1) NOT NULL,
    [Nev] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Szornyek'
CREATE TABLE [dbo].[Szornyek] (
    [SzornyId] int IDENTITY(1,1) NOT NULL,
    [Nev] nvarchar(max)  NOT NULL,
    [Lakhelyfk] int  NOT NULL,
    [Tamadas] int  NOT NULL,
    [Vedes] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Felhasznalonev] in table 'Felhasznalok'
ALTER TABLE [dbo].[Felhasznalok]
ADD CONSTRAINT [PK_Felhasznalok]
    PRIMARY KEY CLUSTERED ([Felhasznalonev] ASC);
GO

-- Creating primary key on [KarakterId] in table 'Karakterek'
ALTER TABLE [dbo].[Karakterek]
ADD CONSTRAINT [PK_Karakterek]
    PRIMARY KEY CLUSTERED ([KarakterId] ASC);
GO

-- Creating primary key on [LakhelyId] in table 'Lakhely'
ALTER TABLE [dbo].[Lakhely]
ADD CONSTRAINT [PK_Lakhely]
    PRIMARY KEY CLUSTERED ([LakhelyId] ASC);
GO

-- Creating primary key on [SzornyId] in table 'Szornyek'
ALTER TABLE [dbo].[Szornyek]
ADD CONSTRAINT [PK_Szornyek]
    PRIMARY KEY CLUSTERED ([SzornyId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LakhelyId] in table 'Lakhely'
ALTER TABLE [dbo].[Lakhely]
ADD CONSTRAINT [FK_SzornyekLakhely]
    FOREIGN KEY ([LakhelyId])
    REFERENCES [dbo].[Szornyek]
        ([SzornyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------