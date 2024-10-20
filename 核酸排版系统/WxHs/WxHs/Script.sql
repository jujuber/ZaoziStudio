--主版信息
create table WX_HSVER
(
   XH INT identity not null,
   BHNO varchar(32) not null,
   GG varchar(16),
   RQ datetime,
   JLZT int,
   DCBZ int,--导出日期
   DCRQ datetime,--导出日期
   DCPATH varchar(256),--导出路径
   ISDATA int,--1：有数据 非1：空板
   MEMO varchar(256),
   CJRY varchar(8) ,
   CJRYMC varchar(32),
   CJRQ datetime,
   XGRY varchar(8),
   XGRYMC varchar(32),
   XGRQ datetime,
)
go
if not exists(select 1 from syscolumns where name='ISDATA' and id=object_id('WX_HSVER'))
      alter table WX_HSVER add ISDATA int NULL--管理员标志   1：管理员，非1：不是管理员
go
--主版对应条码明细
create table WX_HSVERMX
(
   XH INT identity not null,
   HSXH INT not null,
   BHNO varchar(32) not NULL,
   ROWNAME VARCHAR(8),
   A1 varchar(64) NULL,
   A2 varchar(64) NULL,
   A3 varchar(64) NULL,
   A4 varchar(64) NULL,
   A5 varchar(64) NULL,
   A6 varchar(64) NULL,
   A7 varchar(64) NULL,
   A8 varchar(64) NULL,
   A9 varchar(64) NULL,
   A10 varchar(64) NULL,
   A11 varchar(64) NULL,
   A12 varchar(64) NULL,
   A13 varchar(64) NULL,
   A14 varchar(64) NULL,
   A15 varchar(64) NULL,
   A16 varchar(64) NULL,
   A17 varchar(64) NULL,
   A18 varchar(64) NULL,
   A19 varchar(64) NULL,
   A21 varchar(64) NULL,
   A22 varchar(64) NULL,
   A23 varchar(64) NULL,
   A24 varchar(64) NULL,
   A25 varchar(64) NULL,
   A26 varchar(64) NULL,
   A27 varchar(64) NULL,
   A28 varchar(64) NULL,
   A29 varchar(64) NULL,
   A30 varchar(64) NULL,
   BHRQ varchar(8) null,
   LRRQ datetime
)
go
--扫描流水
create table WX_HSWRITELOG
(
   XH INT identity not null,
   HSXH INT not null,
   BHNO varchar(32) not NULL,
   BHRQ varchar(8),
   BARNO VARCHAR(64),
   BARX INT NULL,
   BARY INT NULL,
   SMRQ varchar(20),
   SMRY varchar(8),
   SMRYMC varchar(64)
)
go
--操作流水表
create table WX_CZLS
(
  XH INT identity not null,
  HSXH varchar(32) null,
  CZRY varchar(8) NULL,
  CZRYMC varchar(64) null,
  CZSM varchar(64) null,--操作说明,
  MEMO varchar(max) null,--备注,
  LRRQ datetime,--操作日期
  CONSTRAINT [PK_WX_CZLS_XH] PRIMARY KEY(XH)
)
--登录人员
create table WX_RYXX
(
   ID varchar(8) not null,
   NAME varchar(64) null,
   PY varchar(8) null,
   WB varchar(8) null,
   [PASSWORD] varchar(32) null,
   REGIST_TIME varchar(16) null,
   JLZT int not null -- 0无效  1：有效
)
go
 if not exists(select 1 from syscolumns where name='GLYBZ' and id=object_id('WX_RYXX'))
      alter table WX_RYXX add GLYBZ int NULL--管理员标志   1：管理员，非1：不是管理员
go
--初始化密码是 1234
INSERT [dbo].[WX_RYXX] ([ID], [NAME], [PY], [WB], [PASSWORD], [REGIST_TIME], [JLZT], [GLYBZ]) VALUES (N'1', N'管理员', N'gly', N'gly', N'81DC9BDB52D04DC20036DBD8313ED055', NULL, 1, 1)
INSERT [dbo].[WX_RYXX] ([ID], [NAME], [PY], [WB], [PASSWORD], [REGIST_TIME], [JLZT], [GLYBZ]) VALUES (N'2', N'文兰', N'wl', N'gpg', N'81DC9BDB52D04DC20036DBD8313ED055', NULL, 1,0)
go
--字典
create table WX_ZDXX
(
  FLDM int not null,
  ID  varchar(7) not null,
  NAME varchar(256),
  PY varchar(16) NULL,
  WB varchar(16) NULL,
  PXXH int NULL,
  MRVALUE varchar(16) NULL,
  JLZT int NULL
)
GO
INSERT INTO WX_ZDXX(FLDM,ID,NAME,JLZT) VALUES(1,1,'8*6',1)--规格目前采用固定格式： 列*行  
INSERT INTO WX_ZDXX(FLDM,ID,NAME,JLZT) VALUES(1,2,'12*8',1)
go

--配置表
create table WX_XRGZ
(
  ID VARCHAR(7) NOT NULL,
  NAME VARCHAR(256),--说明
  VALUE VARCHAR(64), --设置的值
  KZFS int,--0确认，1禁止
  MEMO varchar(256) --说明
)
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('1','可以录入的长度','12',1,'默认是空，不校验长度');
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('2','是否要求数字','是',1,'默认是，扫码信息必须是数字才能录入');
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('3','开头第一个字符不能包括的值','4',1,'默认空，不控制开头字符，多个有逗号隔开');
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('4','导出过的板号是否可以修改','是',1,'默认是，可以修改，否：根据控制方式判断');
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('5','扫码录入管码重复校验规则','0',1,'默认0，不校验，1：本院存在的管码，2：本院当天存在的管码');
go


create procedure usp_hsjc_querydata 
  @ksrq varchar(20),-- 开始日期
  @jsrq varchar(20),-- 结束日期
  @ysxx varchar(32) -- 医生信息         
as
/**********  
 
**********/  
set nocount on  
--do something
select 1,2,3,4
return  
go

create procedure usp_hsjc_exportdata 
  @Xh int--核酸序号    
as
/**********  
 按返回的数据导出excel 
**********/  
set nocount on  
 SELECT BARNO 管码,'阴性' as 检测结果 
 FROM WX_HSWRITELOG 
 WHERE HSXH = @Xh
 return  
go
 

