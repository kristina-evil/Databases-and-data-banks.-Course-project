USE accountingMaterials;

SELECT Name FROM Materials ORDER BY Name;

SELECT MaterialID, MaterialCount FROM DebtAct
JOIN Materials ON Materials.ID=DebtAct.MaterialID


