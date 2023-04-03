--1
select * from dba_users;

--2
select * from USER_ROLE_PRIVS;
--SELECT * FROM DBA_ROLES;
--SELECT * FROM dba_tables;
--SELECT * FROM ROLE_TAB_PRIVS;

--3

--Proc create user
create or replace procedure createUser
(user_name in varchar2, pwd in varchar2, ty in int)
as
    lv_stmt   VARCHAR2 (1000);
begin
    --TAO USER
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pwd;
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'GRANT CREATE SESSION TO ' || user_name || '';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    
    -- NHANVIEN
    IF ty = 1
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV, USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- QLTT(NHANVIEN)
    ELSIF ty = 2
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_QLTT TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- TRUONGPHONG(NHANVIEN)    
    ELSIF ty = 3
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_TRUONGPHONG TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- TAICHINH(NHANVIEN)    
    ELSIF ty = 4
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_TAICHINH TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- NHANSU
    ELSIF ty = 5
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')'; 
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_NHANSU TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    --TRUONGDA
     ELSIF ty = 6
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')'; 
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_TRUONGDA TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    --BGD
     ELSIF ty = 7
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(MANV,USERNAME, VAITRO) VALUES(''' || user_name || ''',''' || user_name || ''', ''' || ty || ''')'; 
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_BGD TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    END IF;
end;

--begin
--  createUser('NV069999','123',1);
--end;
--SELECT * FROM NHANVIEN WHERE MANV='NV069999';

--Proc change user
create or replace procedure changeUser
(user_name in varchar2, pwd in varchar2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt );
    lv_stmt := 'ALTER USER ' || user_name || ' IDENTIFIED BY ' || pwd;
    EXECUTE IMMEDIATE ( lv_stmt );
end;

--Proc drop user
create or replace procedure dropUser
(user_name in varchar2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt );
    lv_stmt := 'DROP USER ' || user_name || 'CASCADE';
    EXECUTE IMMEDIATE ( lv_stmt );
end;

--Proc create role
create or replace procedure createRole
(role_name in varchar2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt );
    lv_stmt := 'CREATE ROLE ' || role_name;
    EXECUTE IMMEDIATE ( lv_stmt );
end;

create or replace procedure dropRole
(role_name in varchar2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt );
    lv_stmt := 'DROP ROLE ' || role_name;
    EXECUTE IMMEDIATE ( lv_stmt );
end;
--4


--5
create or replace procedure sp_RevokeRoleFromUser_OR_Role
(role_name in varchar2, userORrole_name in varchar2)
as
    revoke_statement varchar2(255);
begin
    revoke_statement := 'revoke ' || role_name || ' from ' || userORrole_name;
    execute immediate revoke_statement;
end;

--6
select * from nhanvien;
SELECT * FROM dba_users;