USE accountingMaterials;

GO
CREATE PROCEDURE FullRequiementAct AS
SELECT Materials.Name AS Material, RequiredCount, ReleasedCount, Unit.Name AS Unit, Employee.Name As Employee, Materials.Price AS Price, Materials.Price*RequiredCount AS Value1, Materials.Price*ReleasedCount AS Value2 FROM RequiementAct
JOIN Materials ON Materials.ID=RequiementAct.MaterialID
JOIN Unit ON Unit.ID=RequiementAct.UnitID
JOIN Employee ON Employee.ID = RequiementAct.EmployeeID;

GO
CREATE PROCEDURE IncomeTimecards AS
SELECT Materials.Name AS Material, Data, DocumentNumber, FromWhom, Income, Materials.Price*Income AS Value FROM Timecards
JOIN Materials ON Materials.ID=Timecards.MaterialID;

GO 
CREATE PROCEDURE OutcomeTimecards AS
SELECT Materials.Name AS Material, Data, DocumentNumber, FromWhom, Outcome, Materials.Price*Outcome AS Value FROM Timecards
JOIN Materials ON Materials.ID=Timecards.MaterialID;

GO
CREATE PROCEDURE RequiredCountWaybill AS
SELECT Materials.Name AS Material,  Unit.Name AS Unit, RequiredCount, Materials.Price*RequiredCount AS Value, Employee.Name As Employee, DocumentNumber FROM Waybill
JOIN Materials ON Materials.ID=Waybill.MaterialID
JOIN Unit ON Unit.ID=Waybill.UnitID
JOIN Employee ON Employee.ID = Waybill.EmployeeID;

GO
CREATE PROCEDURE ReleasedCountWaybill AS
SELECT Materials.Name AS Material,  Unit.Name AS Unit, ReleasedCount, Materials.Price*ReleasedCount AS Value, Employee.Name As Employee, DocumentNumber FROM Waybill
JOIN Materials ON Materials.ID=Waybill.MaterialID
JOIN Unit ON Unit.ID=Waybill.UnitID
JOIN Employee ON Employee.ID = Waybill.EmployeeID;

GO 
CREATE PROCEDURE RemainsUseInProduction AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, Remains, Materials.Price*Remains AS Value, Employee.Name As Employee FROM UseInProduction
JOIN Materials ON Materials.ID=UseInProduction.MaterialID
JOIN Unit ON Unit.ID=UseInProduction.UnitID
JOIN Employee ON Employee.ID = UseInProduction.EmployeeID;

GO 
CREATE PROCEDURE RequiredCountUseInProduction AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, RequiredCount, Materials.Price*RequiredCount AS Value, Employee.Name As Employee FROM UseInProduction
JOIN Materials ON Materials.ID=UseInProduction.MaterialID
JOIN Unit ON Unit.ID=UseInProduction.UnitID
JOIN Employee ON Employee.ID = UseInProduction.EmployeeID;

GO
CREATE PROCEDURE ActualRiseUseInProduction AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, ActualRise, Materials.Price*ActualRise AS Value, Employee.Name As Employee FROM UseInProduction
JOIN Materials ON Materials.ID=UseInProduction.MaterialID
JOIN Unit ON Unit.ID=UseInProduction.UnitID
JOIN Employee ON Employee.ID = UseInProduction.EmployeeID;

GO
CREATE PROCEDURE FullUseOfMatrials AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, MaterialCount, Materials.Price*MaterialCount AS Value, ManufacturingCost.Name AS [Manufacturing cost], Employee.Name As Employee FROM UseOfMatrials
JOIN Materials ON Materials.ID=UseOfMatrials.MaterialID
JOIN Unit ON Unit.ID=UseOfMatrials.UnitID
JOIN ManufacturingCost ON ManufacturingCost.ID=UseOfMatrials.ManufacturingCostID
JOIN Employee ON Employee.ID = UseOfMatrials.EmployeeID;

GO
CREATE PROCEDURE RequireCountRequirementInvoice AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, RequiredCount, Materials.Price*RequiredCount AS Value, Employee.Name As Employee, DocumentNumber FROM RequirementInvoice
JOIN Materials ON Materials.ID=RequirementInvoice.MaterialID
JOIN Unit ON Unit.ID=RequirementInvoice.UnitID
JOIN Employee ON Employee.ID = RequirementInvoice.EmployeeID;

GO
CREATE PROCEDURE ReleasedCountRequirementInvoice AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, ReleasedCount, Materials.Price*ReleasedCount AS Value, Employee.Name As Employee, DocumentNumber FROM RequirementInvoice
JOIN Materials ON Materials.ID=RequirementInvoice.MaterialID
JOIN Unit ON Unit.ID=RequirementInvoice.UnitID
JOIN Employee ON Employee.ID = RequirementInvoice.EmployeeID;

GO
CREATE VIEW FullDebtAct AS
SELECT Materials.Name AS Material, Unit.Name AS Unit, MaterialCount, Materials.Price*MaterialCount ASValue, Employee.Name As Employee FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID
JOIN Unit ON Unit.ID=DebtAct.UnitID
JOIN Employee ON Employee.ID = DebtAct.EmployeeID;

GO
CREATE PROCEDURE ReleasedCountRequiementAct AS
SELECT Materials.Name AS Material, ReleasedCount, Unit.Name AS Unit, Employee.Name As Employee, Materials.Price AS Price, Materials.Price*ReleasedCount AS Value FROM RequiementAct
JOIN Materials ON Materials.ID=RequiementAct.MaterialID
JOIN Unit ON Unit.ID=RequiementAct.UnitID
JOIN Employee ON Employee.ID = RequiementAct.EmployeeID;

GO
CREATE PROCEDURE RequiredCountRequiementAct AS
SELECT Materials.Name AS Material, RequiredCount, Unit.Name AS Unit, Employee.Name As Employee, Materials.Price AS Price, Materials.Price*RequiredCount AS Value FROM RequiementAct
JOIN Materials ON Materials.ID=RequiementAct.MaterialID
JOIN Unit ON Unit.ID=RequiementAct.UnitID
JOIN Employee ON Employee.ID = RequiementAct.EmployeeID;

GO
CREATE PROCEDURE MaterialCountInDebtAct AS
SELECT Materials.Name, MaterialCount, Materials.Price*MaterialCount AS Value FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID;

GO
CREATE PROCEDURE AvrPrice AS
SELECT AVG(Materials.Price*MaterialCount) AS AvgValue FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID;
