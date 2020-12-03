USE accountingMaterials;

DECLARE curs5 CURSOR
GLOBAL
SCROLL
KEYSET
TYPE_WARNING
FOR
SELECT Name
FROM Unit
FOR READ ONLY
open global curs5
DECLARE
 @@Counter int
 SET @@Counter =@@CURSOR_ROWS
 Select @@Counter 
 CLOSE curs5	
 DEALLOCATE curs5


