-- Inserts the types of alarms needed
INSERT INTO ALARMTYPE
VALUES ('HighTemp', 30.0, 'M�leverdi for temperatur er over �vre grense'),
('LowTemp', 15.0, 'M�leverdi for temperature er under nedre grense'),
('LowBattery', 20, 'Batterispenningen er under nedre grense'),
('NoCharge', null, 'Datamaskinens str�mforsyning er ikke tilkoblet'),
('ComFault', null, 'Kommunikasjon med Arduino feilet'),
('Motion', null, 'Motion detected!')
GO 


