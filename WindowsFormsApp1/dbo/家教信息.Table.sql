﻿CREATE TABLE [dbo].[Table] (
    [家长编号]     VARCHAR (6)   NOT NULL,
    [打印编号]     VARCHAR (8)   NULL,
    [接待人]      VARCHAR (12)  NULL,
    [接入时间]     DATETIME      NULL,
    [家长称呼]     VARCHAR (12)  NULL,
    [联系方式]     VARCHAR (11)  NULL,
    [家教地址简单] VARCHAR (50)  NULL,
    [家教地址详细] VARCHAR (50)  NULL,
    [年级科目]     VARCHAR (50)  NULL,
    [学员性别]     VARCHAR     NULL,
    [家教价格]     FLOAT (53)    NULL,
    [家教时间]     VARCHAR (50)  NULL,
    [教员要求性别] VARCHAR     NULL,
    [教员要求地域] VARCHAR (20)  NULL,
    [教员要求年级] VARCHAR (10)  NULL,
    [教员要求专业] VARCHAR (20)  NULL,
    [教员要求其他] VARCHAR (50)  NULL,
    [家教状态]     VARCHAR (2)   NULL,
    [重要备注]     VARCHAR (50)  NULL,
    [缴费状态]     VARCHAR (4)   NULL,
    [缴费时间]     DATETIME      NULL,
    [教员编号]     VARCHAR (10)  NULL,
    [进行状态]     VARCHAR (2)   NULL,
    [经办时间]     DATETIME NULL,
    [经办人]      VARCHAR (12)  NULL,
    [是否缴费]     VARCHAR (1)   NULL,
    [备注]       VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([家长编号] ASC)
);

