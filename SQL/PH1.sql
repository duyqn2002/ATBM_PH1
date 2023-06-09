alter session set "_ORACLE_SCRIPT"=true; 
--DROP USER U_AD CASCADE;
CREATE USER U_AD IDENTIFIED BY 0;

GRANT ALL PRIVILEGES TO U_AD with ADMIN OPTION;

GRANT SELECT ON DBA_TAB_PRIVS TO U_AD WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO U_AD WITH GRANT OPTION;

GRANT SELECT ON dba_tables to U_AD WITH GRANT OPTION;

GRANT SELECT ON dba_users to U_AD WITH GRANT OPTION;

GRANT SELECT ON USER_ROLE_PRIVS to U_AD WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLES to U_AD WITH GRANT OPTION;

grant execute on DBMS_RLS to U_AD;
grant execute on DBMS_CRYPTO to U_AD;

GRANT SELECT ON dba_audit_trail TO U_AD;

GRANT SELECT ON dba_audit_trail TO U_AD;
GRANT EXECUTE ON DBMS_FGA TO U_AD;
GRANT SELECT ON SYS.FGA_LOG$ TO U_AD;


