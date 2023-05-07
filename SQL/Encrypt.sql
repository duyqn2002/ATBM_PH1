alter session set "_ORACLE_SCRIPT"=true; 
--DROP USER P_ENCRYPT CASCADE;
CREATE USER P_ENCRYPT IDENTIFIED BY 0;

GRANT ALL PRIVILEGES TO P_ENCRYPT with ADMIN OPTION;

grant execute on DBMS_RLS to P_ENCRYPT;
grant execute on DBMS_CRYPTO to P_ENCRYPT;

--DROP TRIGGER ENCRYPT_NV_LUONG;

CREATE OR REPLACE TRIGGER ENCRYPT_NV_LUONG
BEFORE INSERT ON NHANVIEN
FOR EACH ROW
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMTT-N1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.LUONG);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.LUONG := TO_NCHAR(input_string);
END;
/


--DROP TRIGGER ENCRYPT_NV_PHUCAP;

CREATE OR REPLACE TRIGGER ENCRYPT_NV_PHUCAP
BEFORE INSERT ON NHANVIEN
FOR EACH ROW
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMTT-N1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.PHUCAP);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.PHUCAP := TO_NCHAR(input_string);
END;
/

create or replace function DECRYPT_LUONG_PHUCAP (p_data in varchar2)  
    return varchar2  
as  
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMTT-N1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(p_data),
            typ => encryption_type,
            key => v_key
        );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;  
end; 
/


DROP PROCEDURE ENCRYPT_ALL;

CREATE OR REPLACE PROCEDURE ENCRYPT_ALL AS
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMTT-N1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    FOR REC IN (SELECT MANV, LUONG FROM NHANVIEN FOR UPDATE) LOOP
        input_string := TO_CHAR(REC.LUONG);
        encrypted_raw := DBMS_CRYPTO.ENCRYPT(src => UTL_I18N.STRING_TO_RAW(input_string, 'AL32UTF8'),
                                             typ => encryption_type,
                                             key => v_key
                                            );
        input_string := RAWTOHEX(encrypted_raw);
        UPDATE NHANVIEN SET LUONG = input_string WHERE MANV = REC.MANV;
    END LOOP;
    COMMIT;
    
    FOR REC IN (SELECT MANV, PHUCAP FROM NHANVIEN FOR UPDATE) LOOP
        input_string := TO_CHAR(REC.PHUCAP);
        encrypted_raw := DBMS_CRYPTO.ENCRYPT(src => UTL_I18N.STRING_TO_RAW(input_string, 'AL32UTF8'),
                                             typ => encryption_type,
                                             key => v_key
                                            );
        input_string := RAWTOHEX(encrypted_raw);
        UPDATE NHANVIEN SET PHUCAP = input_string WHERE MANV = REC.MANV;
    END LOOP;
    COMMIT;
END;
/


DROP PROCEDURE DECRYPT_ALL;
CREATE OR REPLACE PROCEDURE DECRYPT_ALL AS
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMTT-N1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    FOR REC IN (SELECT MANV, LUONG FROM NHANVIEN FOR UPDATE) LOOP
        decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(REC.LUONG),
            typ => encryption_type,
            key => v_key
        );
        output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
        dbms_output.put_line(output_string);
        UPDATE NHANVIEN SET LUONG = output_string WHERE MANV = REC.MANV;
    END LOOP;
    COMMIT;
    
    FOR REC IN (SELECT MANV, PHUCAP FROM NHANVIEN FOR UPDATE) LOOP
         decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(REC.PHUCAP),
            typ => encryption_type,
            key => v_key
        );
        output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
        dbms_output.put_line(output_string);
        UPDATE NHANVIEN SET PHUCAP = output_string WHERE MANV = REC.MANV;
    END LOOP;
    COMMIT;
END;
/

BEGIN
    ENCRYPT_ALL;
END;

select * from NHANVIEN;

BEGIN
    DECRYPT_ALL;
END;


create or replace view  view_decrypt_LUONG_PHUCAP as
SELECT MANV, CAST (DECRYPT_LUONG_PHUCAP(n.LUONG) AS varchar2 (255)) LUONG,
CAST (DECRYPT_LUONG_PHUCAP(n.PHUCAP) AS varchar2 (255)) PHUCAP  FROM NHANVIEN n;

select * from P_ENCRYPT.view_decrypt_LUONG_PHUCAP;
