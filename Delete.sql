USE accountingMaterials;

TRUNCATE TABLE UnitHistory;

SELECT * INTO EmployeeCopy FROM Employee DELETE EmployeeCopy
DROP TABLE EmployeeCopy;

SELECT * INTO MaterialsCopy FROM Materials
DELETE MaterialsCopy
WHERE Materials.ID >400
DROP TABLE MaterialsCopy;

SELECT * INTO UnitCopy FROM Unit
DELETE UnitCopy WHERE Name LIKE 'À%' DROP TABLE UnitCopy;

