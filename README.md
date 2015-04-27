# MyBatisSample
a simple mybatisnet sample

#database
version:oracle 11g Oracle Database Express Edition 11g Release 2  
connection string:Data Source=xe;User Id=system;Password=test (edit SqlMap.config to change)  

#DDL
DROP TABLE emptab;   
CREATE TABLE emptab (empno NUMBER(4) PRIMARY KEY, ename VARCHAR2(10));  
INSERT INTO emptab VALUES ( 1, 'Mark');  
INSERT INTO emptab VALUES ( 2, 'Roger');  
INSERT INTO emptab VALUES ( 3, 'Crook');  
COMMIT

