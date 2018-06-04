-- Inserts the types of alarms needed
INSERT INTO ALARMTYPE
VALUES ('HighTemp', 30.0, 'Måleverdi for temperatur er over øvre grense'),
('LowTemp', 15.0, 'Måleverdi for temperature er under nedre grense'),
('LowBattery', 20, 'Batterispenningen er under nedre grense'),
('NoCharge', null, 'Datamaskinens strømforsyning er ikke tilkoblet'),
('ComFault', null, 'Kommunikasjon med Arduino feilet'),
('Motion', null, 'Motion detected!')
GO 


