CREATE TABLE [dbo].[Operations] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [leftNumber]   VARCHAR (255)  NULL,
    [rightNumber]  VARCHAR (255)  NULL,
    [mathOperator] VARCHAR (255)  NULL,
    [result]       NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

