/* Metode for å legge til en ny abbonent */
CREATE PROCEDURE NewSubscriber
@Email char(30), @FirstName char(18), @LastName char(18), @Telephone int
AS
INSERT INTO SUBSCRIBER
VALUES (@Email, @FirstName, @LastName, @Telephone)
GO

/* Metode for å lagre en ny temperaturmåling */
CREATE PROCEDURE MeasureTemp
@Temperature float
AS
INSERT INTO TEMPERATURE
VALUES (CURRENT_TIMESTAMP ,@Temperature)
GO

/* Metode for å lagrer en ny alarm i alarmhistorikken */
CREATE PROCEDURE NewAlarm
@Alarm char(30)
AS
INSERT INTO ALARM
VALUES (@Alarm, CURRENT_TIMESTAMP)
GO

/* Metode for å oppdatere grenseverdiene for alarmene */
CREATE PROCEDURE UpdateLimit
@AlarmType char(30), @NewLimit float
AS
UPDATE ALARMTYPE
SET Limit = @NewLimit
WHERE ALARMTYPE.Alarm = @AlarmType
GO

/* Metode som returnerer alarmgrense for en gitt alarm */
CREATE PROCEDURE GetLimit
@AlarmType char(30)
AS
SELECT Limit
FROM ALARMTYPE
WHERE Alarm = @AlarmType
GO

/* Metode som returnerer beskrivelsen til en gitt alarm */
CREATE PROCEDURE GetDescription
@AlarmType char(30)
AS
SELECT [Description]
FROM ALARMTYPE
WHERE Alarm = @AlarmType
GO

-- Metode som oppdaterer en eksisterende abonnent med nye verdier
CREATE PROCEDURE UpdateSubscriber
@Email char(30), @NewEmail char(30), @FirstName char(18), @LastName char(18), @Telephone int
AS
ALTER TABLE SUBSCRIBESTO NOCHECK CONSTRAINT ALL --skrur av FK før oppdatering
UPDATE SUBSCRIBER
SET Email = @NewEmail,
FirstName = @FirstName,
LastName = @LastName,
Telephone = @Telephone
WHERE Email = @Email
UPDATE SUBSCRIBESTO
SET Email = @NewEmail
WHERE Email = @Email
ALTER TABLE SUBSCRIBESTO CHECK CONSTRAINT ALL --setter FK tilbake etter oppdatering
GO

drop procedure UpdateSubscriber

-- Metode som sletter en abonent
CREATE PROCEDURE DeleteSubscriber
@Email char(30)
AS
DELETE SUBSCRIBESTO WHERE Email = @Email
DELETE SUBSCRIBER  WHERE Email = @Email
GO

-- Metode som legger en abonent i abonentliste
CREATE PROCEDURE NewSubscribesTo
@Email char(30), @Alarmtype char(30)
AS
INSERT INTO SUBSCRIBESTO
VALUES (@Alarmtype, @Email)
GO

CREATE PROCEDURE UnsubscribesTo
@Email char(30), @Alarmtype char(30)
AS
DELETE SUBSCRIBESTO
WHERE Email = @Email
AND ALARM = @Alarmtype
GO
