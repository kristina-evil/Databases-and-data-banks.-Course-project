USE accountingMaterials;

GO
CREATE VIEW MaterialsName AS
SELECT Name FROM Materials ORDER BY Name;

GO
CREATE VIEW MaterialCountInDebtAct AS
SELECT Materials.Name, MaterialCount  FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID;

GO
CREATE VIEW FullRequiementAct AS
SELECT Materials.Name AS Material, RequiredCount, ReleasedCount, Unit.Name AS Unit, Employee.Name As Employee FROM RequiementAct
JOIN Materials ON Materials.ID=RequiementAct.MaterialID
JOIN Unit ON Unit.ID=RequiementAct.UnitID
JOIN Employee ON Employee.ID = RequiementAct.EmployeeID;

GO
CREATE VIEW FullTimecards AS
SELECT Materials.Name AS Material, Data, DocumentNumber, FromWhom, Income, Outcome FROM Timecards
JOIN Materials ON Materials.ID=Timecards.MaterialID;

GO
CREATE VIEW FullWaybill AS
SELECT Materials.Name AS Material,  Unit.Name AS Unit, RequiredCount, ReleasedCount, Employee.Name As Employee, DocumentNumber FROM Waybill
JOIN Materials ON Materials.ID=Waybill.MaterialID
JOIN Unit ON Unit.ID=Waybill.UnitID
JOIN Employee ON Employee.ID = Waybill.EmployeeID;

GO
CREATE VIEW FullUseInProduction AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, Remains, RequiredCount, ActualRise, Employee.Name As Employee FROM UseInProduction
JOIN Materials ON Materials.ID=UseInProduction.MaterialID
JOIN Unit ON Unit.ID=UseInProduction.UnitID
JOIN Employee ON Employee.ID = UseInProduction.EmployeeID;

GO
CREATE VIEW FullUseOfMatrials AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, MaterialCount, ManufacturingCost.Name AS [Manufacturing cost], Employee.Name As Employee FROM UseOfMatrials
JOIN Materials ON Materials.ID=UseOfMatrials.MaterialID
JOIN Unit ON Unit.ID=UseOfMatrials.UnitID
JOIN ManufacturingCost ON ManufacturingCost.ID=UseOfMatrials.ManufacturingCostID
JOIN Employee ON Employee.ID = UseOfMatrials.EmployeeID;

GO
CREATE VIEW FullRequirementInvoice AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, RequiredCount, ReleasedCount, Employee.Name As Employee, DocumentNumber FROM RequirementInvoice
JOIN Materials ON Materials.ID=RequirementInvoice.MaterialID
JOIN Unit ON Unit.ID=RequirementInvoice.UnitID
JOIN Employee ON Employee.ID = RequirementInvoice.EmployeeID;

GO
CREATE VIEW FullDebtAct AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, MaterialCount, Employee.Name As Employee FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID
JOIN Unit ON Unit.ID=DebtAct.UnitID
JOIN Employee ON Employee.ID = DebtAct.EmployeeID;

GO
CREATE VIEW MaterialsPrice AS
SELECT ID, Name, Price FROM Materials ORDER BY Price;

GO
CREATE VIEW EmployeePosition AS
SELECT Name, Position FROM Employee ORDER BY Position;

GO
CREATE VIEW UnitName AS
SELECT ID, Name FROM Unit ORDER BY Name;

GO
CREATE VIEW ManufacturingCostName AS
SELECT ID, Name FROM ManufacturingCost ORDER BY Name;

GO
Create VIEW WaybillEmployee AS
SELECT Employee.Name As Employee, DocumentNumber FROM Waybill
JOIN Employee ON Employee.ID = Waybill.EmployeeID;

GO
CREATE VIEW RequirementInvoiceEmployee AS
SELECT Employee.Name As Employee, DocumentNumber FROM RequirementInvoice
JOIN Employee ON Employee.ID = RequirementInvoice.EmployeeID;
GO