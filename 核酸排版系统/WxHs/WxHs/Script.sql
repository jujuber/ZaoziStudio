--������Ϣ
create table WX_HSVER
(
   XH INT identity not null,
   BHNO varchar(32) not null,
   GG varchar(16),
   RQ datetime,
   JLZT int,
   DCBZ int,--��������
   DCRQ datetime,--��������
   DCPATH varchar(256),--����·��
   ISDATA int,--1�������� ��1���հ�
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
      alter table WX_HSVER add ISDATA int NULL--����Ա��־   1������Ա����1�����ǹ���Ա
go
--�����Ӧ������ϸ
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
--ɨ����ˮ
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
--������ˮ��
create table WX_CZLS
(
  XH INT identity not null,
  HSXH varchar(32) null,
  CZRY varchar(8) NULL,
  CZRYMC varchar(64) null,
  CZSM varchar(64) null,--����˵��,
  MEMO varchar(max) null,--��ע,
  LRRQ datetime,--��������
  CONSTRAINT [PK_WX_CZLS_XH] PRIMARY KEY(XH)
)
--��¼��Ա
create table WX_RYXX
(
   ID varchar(8) not null,
   NAME varchar(64) null,
   PY varchar(8) null,
   WB varchar(8) null,
   [PASSWORD] varchar(32) null,
   REGIST_TIME varchar(16) null,
   JLZT int not null -- 0��Ч  1����Ч
)
go
 if not exists(select 1 from syscolumns where name='GLYBZ' and id=object_id('WX_RYXX'))
      alter table WX_RYXX add GLYBZ int NULL--����Ա��־   1������Ա����1�����ǹ���Ա
go
--��ʼ�������� 1234
INSERT [dbo].[WX_RYXX] ([ID], [NAME], [PY], [WB], [PASSWORD], [REGIST_TIME], [JLZT], [GLYBZ]) VALUES (N'1', N'����Ա', N'gly', N'gly', N'81DC9BDB52D04DC20036DBD8313ED055', NULL, 1, 1)
INSERT [dbo].[WX_RYXX] ([ID], [NAME], [PY], [WB], [PASSWORD], [REGIST_TIME], [JLZT], [GLYBZ]) VALUES (N'2', N'����', N'wl', N'gpg', N'81DC9BDB52D04DC20036DBD8313ED055', NULL, 1,0)
go
--�ֵ�
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
INSERT INTO WX_ZDXX(FLDM,ID,NAME,JLZT) VALUES(1,1,'8*6',1)--���Ŀǰ���ù̶���ʽ�� ��*��  
INSERT INTO WX_ZDXX(FLDM,ID,NAME,JLZT) VALUES(1,2,'12*8',1)
go

--���ñ�
create table WX_XRGZ
(
  ID VARCHAR(7) NOT NULL,
  NAME VARCHAR(256),--˵��
  VALUE VARCHAR(64), --���õ�ֵ
  KZFS int,--0ȷ�ϣ�1��ֹ
  MEMO varchar(256) --˵��
)
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('1','����¼��ĳ���','12',1,'Ĭ���ǿգ���У�鳤��');
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('2','�Ƿ�Ҫ������','��',1,'Ĭ���ǣ�ɨ����Ϣ���������ֲ���¼��');
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('3','��ͷ��һ���ַ����ܰ�����ֵ','4',1,'Ĭ�Ͽգ������ƿ�ͷ�ַ�������ж��Ÿ���');
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('4','�������İ���Ƿ�����޸�','��',1,'Ĭ���ǣ������޸ģ��񣺸��ݿ��Ʒ�ʽ�ж�');
go
insert into WX_XRGZ(ID,NAME,VALUE,KZFS,MEMO)
VALUES('5','ɨ��¼������ظ�У�����','0',1,'Ĭ��0����У�飬1����Ժ���ڵĹ��룬2����Ժ������ڵĹ���');
go


create procedure usp_hsjc_querydata 
  @ksrq varchar(20),-- ��ʼ����
  @jsrq varchar(20),-- ��������
  @ysxx varchar(32) -- ҽ����Ϣ         
as
/**********  
 
**********/  
set nocount on  
--do something
select 1,2,3,4
return  
go

create procedure usp_hsjc_exportdata 
  @Xh int--�������    
as
/**********  
 �����ص����ݵ���excel 
**********/  
set nocount on  
 SELECT BARNO ����,'����' as ����� 
 FROM WX_HSWRITELOG 
 WHERE HSXH = @Xh
 return  
go
 

