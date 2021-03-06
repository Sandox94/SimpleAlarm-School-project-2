-- The following statements creates the database and tables for the Alarmsystem Database
use master;
go

CREATE DATABASE Alarmsystem;
go

USE Alarmsystem;
go

CREATE TABLE SUBSCRIBER 
(
Email varchar (30),
FirstName varchar(18) NOT NULL,
LastName varchar(18) NOT NULL,
Telephone int,
CONSTRAINT PK_SUBSCRIBER PRIMARY KEY (Email)
);
go

CREATE TABLE TEMPERATURE
(
[Time] datetime,
Temperature float NOT NULL,
CONSTRAINT PK_TEMPERATURE PRIMARY KEY ([Time]) 
);
go

CREATE TABLE ALARMTYPE
(
Alarm varchar(30),
Limit float,
[Description] varchar(100),
CONSTRAINT PK_ALARMTYPE PRIMARY KEY (Alarm)
);
go

CREATE TABLE ALARM
(
Alarm varchar(30),
[Time] datetime,
CONSTRAINT PK_ALARM PRIMARY KEY (Alarm, [Time]),
CONSTRAINT FK_ALARMTYPE_ALARM FOREIGN KEY (Alarm)
REFERENCES ALARMTYPE (Alarm)
);
go

CREATE TABLE SUBSCRIBESTO
(
Alarm varchar(30),
Email varchar(30),
CONSTRAINT PK_SUBSCRIBESTO PRIMARY KEY (Alarm, Email),
CONSTRAINT FK_ALARMTYPE_SUBSCRIBESTO FOREIGN KEY (Alarm)
REFERENCES ALARMTYPE (Alarm),
CONSTRAINT FK_SUBSCRIBER_SUBSCRIBESTO FOREIGN KEY (Email)
REFERENCES SUBSCRIBER (Email)
);
go

-- Inserts the types of alarms needed
INSERT INTO ALARMTYPE
VALUES ('HighTemp', 30.0, 'M�leverdi for temperatur er over �vre grense'),
('LowTemp', 15.0, 'M�leverdi for temperature er under nedre grense'),
('LowBattery', null, 'Batterispenningen er under nedre grense'),
('NoCharge', null, 'Datamaskinens str�mforsyning er ikke tilkoblet'),
('ComFault', null, 'Kommunikasjon med Arduino feilet'),
('Motion', null, 'Motion detected!');
go

/* Metode for � legge til en ny abbonent */
CREATE PROCEDURE NewSubscriber
@Email varchar(30), @FirstName varchar(18), @LastName varchar(18), @Telephone int
AS
INSERT INTO SUBSCRIBER
VALUES (@Email, @FirstName, @LastName, @Telephone);
go

/* Metode for � lagre en ny temperaturm�ling */
CREATE PROCEDURE MeasureTemp
@Temperature float
AS
INSERT INTO TEMPERATURE
VALUES (CURRENT_TIMESTAMP ,@Temperature);
go

/* Metode for � lagrer en ny alarm i alarmhistorikken */
CREATE PROCEDURE NewAlarm
@Alarm varchar(30)
AS
INSERT INTO ALARM
VALUES (@Alarm, CURRENT_TIMESTAMP);
go

/* Metode for � oppdatere grenseverdiene for alarmene */
CREATE PROCEDURE UpdateLimit
@AlarmType varchar(30), @NewLimit float
AS
UPDATE ALARMTYPE
SET Limit = @NewLimit
WHERE ALARMTYPE.Alarm = @AlarmType;
go

/* Metode som returnerer alarmgrense for en gitt alarm */
CREATE PROCEDURE GetLimit
@AlarmType varchar(30)
AS
SELECT Limit
FROM ALARMTYPE
WHERE Alarm = @AlarmType;
go

/* Metode som returnerer beskrivelsen til en gitt alarm */
CREATE PROCEDURE GetDescription
@AlarmType varchar(30)
AS
SELECT [Description]
FROM ALARMTYPE
WHERE Alarm = @AlarmType;
go

-- Metode som oppdaterer en eksisterende abonnent med nye verdier
CREATE PROCEDURE UpdateSubscriber
@Email varchar(30), @NewEmail varchar(30), @FirstName varchar(18), @LastName varchar(18), @Telephone int
AS
ALTER TABLE SUBSCRIBESTO NOCHECK CONSTRAINT ALL --skrur av FK f�r oppdatering
UPDATE SUBSCRIBER
SET Email = @NewEmail,
FirstName = @FirstName,
LastName = @LastName,
Telephone = @Telephone
WHERE Email = @Email
UPDATE SUBSCRIBESTO
SET Email = @NewEmail
WHERE Email = @Email
ALTER TABLE SUBSCRIBESTO CHECK CONSTRAINT ALL; --setter FK tilbake etter oppdatering
go

-- Metode som sletter en abonent
CREATE PROCEDURE DeleteSubscriber
@Email varchar(30)
AS
DELETE SUBSCRIBESTO WHERE Email = @Email
DELETE SUBSCRIBER  WHERE Email = @Email;
go

-- Metode som legger en abonent i abonentliste
CREATE PROCEDURE NewSubscribesTo
@Email varchar(30), @Alarmtype varchar(30)
AS
INSERT INTO SUBSCRIBESTO
VALUES (@Alarmtype, @Email);
go

CREATE PROCEDURE UnsubscribesTo
@Email varchar(30), @Alarmtype varchar(30)
AS
DELETE SUBSCRIBESTO
WHERE Email = @Email
AND ALARM = @Alarmtype;
go
