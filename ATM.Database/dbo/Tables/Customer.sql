CREATE TABLE [dbo].[Customer] (
    [Id]       INT         IDENTITY (101, 1) NOT NULL,
    [AccName]  NCHAR (100) NOT NULL,
    [AccNo]    NCHAR (100) NOT NULL,
    [AccType]  NCHAR (100) NOT NULL,
    [PIN]      BIGINT      NOT NULL,
    [Gender]   NCHAR (10)  NULL,
    [NID]      BIGINT      NULL,
    [Address]  NCHAR (200) NULL,
    [Email]    NCHAR (100) NULL,
    [PhoneNo]  NCHAR (20)  NULL,
    [Branch]   NCHAR (50)  NULL,
    [OpenDate] DATE        NULL,
    [Image]    IMAGE       NOT NULL,
    [Balance]  BIGINT      CONSTRAINT [DF_Customer_Balance] DEFAULT ((100)) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

