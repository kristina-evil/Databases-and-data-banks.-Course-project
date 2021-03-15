USE accountingMaterials;

CREATE INDEX ix_empid ON Employee(ID);

CREATE NONCLUSTERED INDEX ix_matid ON Materials(ID, Number);

CREATE INDEX ix_unid ON Unit(ID);

CREATE NONCLUSTERED INDEX ix_tcid ON Timecards(ID);

CREATE INDEX ix_raid ON RequiementAct(ID);