CREATE TABLE [dbo].[Tutors] (
    [教员编号]     VARCHAR (8)  NOT NULL,
    [姓名]       VARCHAR (20) NOT NULL,
    [学号]       VARCHAR (7)  NOT NULL,
    [院系专业]     VARCHAR (30) NOT NULL,
    [在读学位]     VARCHAR (4)  NOT NULL,
    [性别]       VARCHAR (2)  NOT NULL,
    [联系方式]     VARCHAR (11) NOT NULL,
    [生源地]      VARCHAR (50) NOT NULL,
    [是否黑名单]    BIT  NOT NULL DEFAULT 0 ,
    [相关说明及监禁期] VARCHAR (50) NULL,
    [重要备注]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([教员编号] ASC)
);

