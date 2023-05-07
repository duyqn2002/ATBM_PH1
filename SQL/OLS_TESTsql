--CAU 3
--===== CHAY DUOI QUYEN SYSDBA ======
SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';

EXEC LBACSYS.CONFIGURE_OLS;  -- This procedure registers Oracle Label Security.
/
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; -- This procedure enables it.
/
alter session set "_ORACLE_SCRIPT"=true;
ALTER USER LBACSYS ACCOUNT UNLOCK IDENTIFIED BY 0;
/
grant create session to LBACSYS ;

-- ===== CHAY DUOI QUYEN LBACSYS =======
-- Xoa policy
--exec sa_sysdba.drop_policy('NOTIFICATION_OLS',TRUE);
-- Tao policy
exec sa_sysdba.create_policy(policy_name => 'NOTIFICATION_OLS',column_name => 'row_label');
/
-- Gan quyen cho Quan tri vien
alter session set "_ORACLE_SCRIPT"=true;

grant NOTIFICATION_OLS_DBA to U_AD;

grant execute on SA_COMPONENTS to U_AD;
grant execute on SA_LABEL_ADMIN to U_AD;
grant execute on SA_POLICY_ADMIN to U_AD;
grant execute on SA_USER_ADMIN to U_AD;
grant execute on CHAR_TO_LABEL to U_AD;


-- ===== CHAY DUOI QUYEN U_AD =====
-- Tao level
BEGIN
sa_components.create_level(
    policy_name => 'NOTIFICATION_OLS',
    long_name => 'Giam doc',
    short_name => 'GD',
    level_num => 1000);

sa_components.create_level(
    policy_name => 'NOTIFICATION_OLS',
    long_name => 'Truong phong',
    short_name => 'TP',
    level_num => 500);

sa_components.create_level(
    policy_name => 'NOTIFICATION_OLS',
    long_name => 'Nhan vien',
    short_name => 'NV',
    level_num => 50);
END;
/

-- Tao compartments
exec sa_components.create_compartment('NOTIFICATION_OLS',1000,'MB','Mien bac');
/
exec sa_components.create_compartment('NOTIFICATION_OLS',2000,'MT','Mien trung');
/
exec sa_components.create_compartment('NOTIFICATION_OLS',3000,'MN','Mien nam');
/

-- Tao groups
  
exec sa_components.create_group('NOTIFICATION_OLS',1,'MBAN','Mua ban',NULL);
/
exec sa_components.create_group('NOTIFICATION_OLS',2,'SXUAT','San xuat',NULL);
/
exec sa_components.create_group('NOTIFICATION_OLS',3,'GCONG','Gia cong',NULL);
/

-- Tao label
--a
--GD doc toan bo du lieu
--execute sa_label_admin.drop_label('NOTIFICATION_OLS','GD:MB,MT,MN:ALV');
--/
--execute sa_label_admin.create_label('NOTIFICATION_OLS',2001,'GD:MB,MT,MN:ALV');
--/

execute sa_label_admin.create_label('NOTIFICATION_OLS',2001,'GD:MB,MT,MN:MBAN,SXUAT,GCONG');
/
--Truong phong mien nam san xuat
execute sa_label_admin.create_label('NOTIFICATION_OLS',2002,'TP:MN:SXUAT');
/
--GD mien bac
execute sa_label_admin.create_label('NOTIFICATION_OLS',2003,'GD:MB:MBAN,SXUAT,GCONG');
/

--b
--t1: TP alv
--execute sa_label_admin.drop_label('NOTIFICATION_OLS','TP:MB,MT,MN:ALV');
--/
--execute sa_label_admin.create_label('NOTIFICATION_OLS',2004,'TP:MB,MT,MN:ALV');
--/

--execute sa_label_admin.drop_label('NOTIFICATION_OLS','TP:MB,MT,MN:MBAN,SXUAT,GCONG');
--/
execute sa_label_admin.create_label('NOTIFICATION_OLS',2004,'TP:MB,MT,MN:MBAN,SXUAT,GCONG');
/
--execute sa_label_admin.create_label('NOTIFICATION_OLS',2004,'TP:MB,MT,MN');
--/

--c
--t2: TP mien trung san xuat
execute sa_label_admin.create_label('NOTIFICATION_OLS',2005,'TP:MT:SXUAT');
/

--d
--NV mien nam giacong
execute sa_label_admin.create_label('NOTIFICATION_OLS',2006,'NV:MN:GCONG');
/


- Xoa bang
drop table THONGBAO purge;
-- Tao bang du lieu
create table THONGBAO(
    NOIDUNG varchar2(255),
    NGAYGIO Date,
    CAP number, -- 3:Giam doc; 2:Truong phong; 1:Nhan vien (CO PHAN BIET THU TU)
    MIEN number, -- 3:Mien bac; 2:Mien trung; 1:Mien nam; 0:Tat ca vung mien
    LINHVUC number -- 3:Mua ban; 2:San xuat; 1:Gia cong, 0:Tat ca linh vuc
);

-- Them du lieu vao bang THONGBAO
insert into THONGBAO values ('Thong bao den Giam doc',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),3,0,0);
insert into THONGBAO values ('Thong bao den Truong phong san xuat mien nam',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),2,1,2);
insert into THONGBAO values ('Thong bao den Giam doc mien bac',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),3,3,0);
insert into THONGBAO values ('Thong bao den Truong phong',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),2,0,0);
insert into THONGBAO values ('Thong bao den Truong phong san xuat mien trung',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),2,2,2);
insert into THONGBAO values ('Thong bao den Nhan vien gia cong mien nam',TO_DATE('2023/4/24 ', 'yyyy/mm/dd '),1,1,1);

-- gan chinh sach ban dau cho bang de gan label cho du lieu
begin
sa_policy_admin.apply_table_policy
(policy_name => 'NOTIFICATION_OLS',
schema_name => 'U_AD',
table_name => 'THONGBAO',
table_options => 'NO_CONTROL');
end;
/

-- gan chinh sach cho cac du lieu
update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'GD:MB,MT,MN:MBAN,SXUAT,GCONG')
where CAP = 3 and MIEN = 0 and LINHVUC = 0;

update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'TP:MN:SXUAT')
where CAP = 2 and MIEN = 1 and LINHVUC = 2;

update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'GD:MB:MBAN,SXUAT,GCONG')
where CAP = 3 and MIEN = 3 and LINHVUC = 0;

update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'TP:MB,MT,MN:MBAN,SXUAT,GCONG')
where CAP = 2 and MIEN = 0 and LINHVUC = 0;

update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'TP:MT:SXUAT')
where CAP = 2 and MIEN = 2 and LINHVUC = 2;

update THONGBAO 
set row_label = char_to_label('NOTIFICATION_OLS', 'NV:MN:GCONG')
where CAP = 1 and MIEN = 1 and LINHVUC = 1;


-- Delete policy
BEGIN
  sa_policy_admin.remove_table_policy(
  policy_name  => 'NOTIFICATION_OLS',
  schema_name  => 'U_AD',
  table_name  => 'THONGBAO');
end;
/
-- Apply policy
begin
  sa_policy_admin.apply_table_policy(
  policy_name  => 'NOTIFICATION_OLS',
  schema_name  => 'U_AD',
  table_name  => 'THONGBAO',
  table_options  => 'READ_CONTROL');
end;
/

-- Tao cac loai nguoi dung
alter session set "_ORACLE_SCRIPT"=true;

create user GD identified by 0;
grant create session to GD;

create user TP_MN_SXUAT identified by 0;
grant create session to TP_MN_SXUAT;

create user GD_MB identified by 0;
grant create session to GD_MB;

create user TP identified by 0;
grant create session to TP;

create user TP_MT_SXUAT identified by 0;
grant create session to TP_MT_SXUAT;

create user NV_MN_GCONG identified by 0;
grant create session to NV_MN_GCONG;

grant select on THONGBAO to GD;
grant select on THONGBAO to TP_MN_SXUAT;
grant select on THONGBAO to GD_MB;
grant select on THONGBAO to TP;
grant select on THONGBAO to TP_MT_SXUAT;
grant select on THONGBAO to NV_MN_GCONG;


--Set user label
begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'GD',
  max_read_label => 'GD:MB,MT,MN:MBAN,SXUAT,GCONG');
end;
/

begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'TP_MN_SXUAT',
  max_read_label => 'TP:MN:SXUAT');
end;
/

begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'GD_MB',
  max_read_label => 'GD:MB:MBAN,SXUAT,GCONG');
end;
/

begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'TP',
  max_read_label => 'TP:MB,MT,MN:MBAN,SXUAT,GCONG');
end;
/

begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'TP_MT_SXUAT',
  max_read_label => 'TP:MT:SXUAT');
end;
/

begin
sa_user_admin.set_user_labels
  (policy_name => 'NOTIFICATION_OLS',
  user_name => 'NV_MN_GCONG',
  max_read_label => 'NV:MN:GCONG');
end;
/

select * from U_AD.THONGBAO;