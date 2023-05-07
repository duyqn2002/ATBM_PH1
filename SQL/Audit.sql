--4

--xoa audit policy
--A
BEGIN
    DBMS_FGA.DROP_POLICY (
        object_schema => 'U_AD',
        policy_name => 'AUDIT_PHANCONG_THOIGIAN',
        object_name => 'PHANCONG'
    );
END;
/

--B
BEGIN
    DBMS_FGA.DROP_POLICY (
        object_schema => 'U_AD',
        policy_name => 'AUDIT_NHANVIEN_LUONG_PHUCAP_OTHER',
        object_name => 'NHANVIEN'
    );
END;
/


--C
BEGIN
    DBMS_FGA.DROP_POLICY (
        object_schema => 'U_AD',
        policy_name => 'AUDIT_NHANVIEN_LUONG_PHUCAP_UPDATE',
        object_name => 'NHANVIEN'
    );
END;
/


-------------- CAI DAT POLICY --------------
--A
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'PHANCONG',
   policy_name        => 'AUDIT_PHANCONG_THOIGIAN',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'THOIGIAN',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/
--SELECT * FROM PHANCONG;
--UPDATE PHANCONG
--SET THOIGIAN = '09-NOV-06'
--WHERE MANV='NV018';


--B
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'NHANVIEN',
   policy_name        => 'AUDIT_NHANVIEN_LUONG_PHUCAP_OTHER',
   audit_condition => 'USERNAME != USER',
   enable             =>  TRUE,
   statement_types    => 'SELECT',
   audit_column       => 'LUONG, PHUCAP',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/


--C
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'NHANVIEN',
   policy_name        => 'AUDIT_NHANVIEN_LUONG_PHUCAP_UPDATE',
   audit_condition => 'USER NOT LIKE ''%TC%'' ',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'LUONG, PHUCAP',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--SELECT * FROM NHANVIEN;
--select * from U_AD.NV_SELECT_NHANVIEN;
--CHECK AUDIT

--SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$