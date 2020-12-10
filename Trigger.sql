USE accountingMaterials;

GO
CREATE TRIGGER Materials_INSERT
ON Materials
AFTER INSERT
AS
INSERT INTO MaterialsHistory (MaterialId, Operation)
SELECT ID, 'Add material ' + Name
FROM INSERTED;

GO
CREATE TRIGGER Materials_DELETE
ON Materials
AFTER DELETE
AS
INSERT INTO MaterialsHistory (MaterialId, Operation)
SELECT ID, 'Delete material ' + Name
FROM DELETED;

GO
CREATE TRIGGER Employee_INSERT
ON Employee
AFTER INSERT
AS
INSERT INTO EmployeeHistory (EmployeeId, Operation)
SELECT ID, 'Add employee ' + Name
FROM INSERTED;

GO
CREATE TRIGGER Employee_DELETE
ON Employee
AFTER DELETE
AS
INSERT INTO EmployeeHistory (EmployeeId, Operation)
SELECT ID, 'Delete employee ' + Name
FROM DELETED;

GO
CREATE TRIGGER Unit_INSERT
ON Unit
AFTER INSERT
AS
INSERT INTO UnitHistory (UnitId, Operation)
SELECT ID, 'Add unit ' + Name
FROM INSERTED;

GO
CREATE TRIGGER Unit_DELETE
ON Unit
AFTER DELETE
AS
INSERT INTO UnitHistory (UnitId, Operation)
SELECT ID, 'Delete unit ' + Name
FROM DELETED;

GO
CREATE TRIGGER ManufacturingCost_INSERT
ON ManufacturingCost
AFTER INSERT
AS
INSERT INTO ManufacturingCostHistory (ManufacturingCostId, Operation)
SELECT ID, 'Add Manufacturing Cost ' + Name
FROM INSERTED;

GO
CREATE TRIGGER ManufacturingCost_DELETE
ON ManufacturingCost
AFTER DELETE
AS
INSERT INTO ManufacturingCostHistory (ManufacturingCostId, Operation)
SELECT ID, 'Delete Manufacturing Cost ' + Name
FROM DELETED;