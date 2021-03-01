USE accountingMaterials;

UPDATE Employee SET Position ='Начальник механосборочного цеха'
WHERE Position='Начальник МСЦ';

UPDATE Materials SET Price=3.10
WHERE Price>3 AND Price<3.10