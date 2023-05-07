
-- B2: Dang nhap bang U_AD va chay lan luot cac cau lenh sau
alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;

-- Theo doi hanh vi cua cac user tren tat ca cac table
AUDIT ALL ON U_AD.NHANVIEN BY ACCESS;
AUDIT ALL ON U_AD.PHONGBAN BY ACCESS;
AUDIT ALL ON U_AD.DEAN BY ACCESS;
AUDIT ALL ON U_AD.PHANCONG BY ACCESS;



-- Theo doi cac hanh vi thanh cong
AUDIT ALL WHENEVER SUCCESSFUL;

-- Theo doi cac hanh vi khong thanh cong
AUDIT ALL WHENEVER NOT SUCCESSFUL;

--------------------AUDIT TESTING--------------------
--B1: dang nhap bang user THANHTRA_6 (khac U_AD la duoc) va chay cau lenh sau:
SELECT * FROM U_AD.NHANVIEN;

-- B2: dang nhap bang U_AD, chay cau lenh sau de xem ket qua audit:
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text 
from dba_audit_trail
WHERE OBJ_NAME = 'NHANVIEN';