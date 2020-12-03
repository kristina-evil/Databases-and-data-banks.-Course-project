USE accountingMaterials;

DECLARE curs3 CURSOR
GLOBAL SCROLL KEYSET 
TYPE_WARNING 
FOR
SELECT MaterialID, ActualRise FROM UseInProduction
JOIN Materials ON Materials.ID=UseInProduction.MaterialID
FOR UPDATE
open global curs3
DECLARE
@@Name VARCHAR(150),
@@Count INT,
@@Counter INT,
@@Var1 INT
SET @@Counter = 1 
WHILE @@Counter< @@CURSOR_ROWS 
BEGIN
FETCH curs3 INTO @@Name, @@Count
SET @@Counter =@@Counter +1 
END
SELECT @@Counter
CLOSE curs3
DEALLOCATE curs3

