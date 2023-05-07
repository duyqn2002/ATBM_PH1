DROP FUNCTION CS_01;
CREATE OR REPLACE FUNCTION CS_01 (p_schema VARCHAR2, p_object VARCHAR2)
RETURN VARCHAR2
AS
    BEGIN
        IF (p_object = 'NHANVIEN') THEN
            RETURN 'USERNAME = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
        ELSIF (p_object = 'PHANCONG') THEN
            RETURN 'USERNAME = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
        ELSE RETURN '1=0';
        END IF;
    END;
/
-- Drop policy
BEGIN
    DBMS_RLS.DROP_POLICY (
        policy_name => 'CapNhatThongTin', 
        object_schema => 'U_AD', 
        object_name => 'NHANVIEN'
    );
END;
/

BEGIN
     DBMS_RLS.ADD_POLICY (
        object_schema => 'U_AD', 
        object_name => 'NHANVIEN',
        policy_name => 'CapNhatThongTin',
        function_schema => 'U_AD',
        policy_function => 'CS_01',
        sec_relevant_cols => 'NGAYSINH, DIACHI, SODT',
        statement_types => 'update');
END;
/