﻿CREATE DATABASE PAYWITHSERVICES

USE PAYWITHSERVICES
-------------------------------------------------
 GO
 if (OBJECT_ID ('USUARIO', 'U')) is not null
     DROP TABLE USUARIO ;
 GO
 CREATE TABLE USUARIO(
 USERACCOUNT NVARCHAR(15) PRIMARY KEY NOT NULL,
 PASSWORD NVARCHAR(20) NOT NULL,
 PROFILEPICTURE IMAGE,
 CEDULA VARCHAR(9) UNIQUE NOT NULL,
 NOMBRE NVARCHAR(20) NOT NULL,
 APELLIDOS NVARCHAR (25) NOT NULL,
 SEXO NVARCHAR(15) NOT NULL,
 EMAIL NVARCHAR(30) NOT NULL,
 TELEFONO VARCHAR(12) NOT NULL,
 AREALAB VARCHAR(30) NOT NULL,
 )

-------------------------------------------------
 GO
 if (OBJECT_ID ('CARRERAS', 'U')) is not null
     DROP TABLE CARRERAS ;

 CREATE TABLE CARRERAS(
 NOMBRE VARCHAR(30)
 )

-------------------------------------------------
 GO
 if (OBJECT_ID ('SERVICIO', 'U')) is not null
     DROP TABLE SERVICIO ;

 CREATE TABLE SERVICIO(
 ID_SERVICIO VARCHAR(10) PRIMARY KEY NOT NULL,
 USERACCOUNT NVARCHAR(15) NOT NULL FOREIGN KEY (USERACCOUNT) REFERENCES USUARIO(USERACCOUNT),
 FECHA VARCHAR(12) NOT NULL,
 AREA_BRIN VARCHAR(30) NOT NULL,
 NOMBRE_BRIN VARCHAR(25) NOT NULL,
 DESCRIPCION1 NVARCHAR(300) NOT NULL,
 AREA_BUSQ VARCHAR(30) NOT NULL,
 NOMBRE_BUSQ VARCHAR(25) NOT NULL,
 DESCRIPCION2 NVARCHAR(300) NOT NULL,
 VALORPROME FLOAT NOT NULL
 )

 Select * from USUARIO

