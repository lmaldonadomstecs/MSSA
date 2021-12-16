-- This is a single line comment
/*
This is a
Multiline
Comment
*/

-- This command creates a new Database.
create database newDatabase;
-- This command deletes a database
--drop database newDatabase
-- use command is used to select a database context.
use MyFirstDatabase;

-- This command prints my tables
select * from sys.tables; -- This is from TSQL's syntax

-- This is how you create a table
create table warehouse (
	Id int IDENTITY(1,1), -- first field must be the ID
	firstColumn varchar(50) not null, -- varchar is a string of characters
	secondColumn float not null,
	thirdColumn int not null,
	PRIMARY KEY (Id)
);


create table tCustomer (
	Id int IDENTITY(1,1) PRIMARY KEY, -- first field must be the ID
	firstColumn varchar(50) not null, -- varchar is a string of characters
	secondColumn float not null,
	thirdColumn int not null
);

create table tOrder (
	Id int IDENTITY(1,1) PRIMARY KEY, -- first field must be the ID
	firstColumn varchar(50) not null, -- varchar is a string of characters
	secondColumn float not null,
	thirdColumn int not null,
	CustomerId int FOREIGN KEY REFERENCES tCustomer(Id)
);

create table tOrder (
	Id int IDENTITY(1,1) PRIMARY KEY, -- first field must be the ID
	firstColumn varchar(50) not null, -- varchar is a string of characters
	secondColumn float not null,
	thirdColumn int not null,
	CustomerId int,
	FOREIGN KEY (CustomerId) REFERENCES tCustomer(Id)
);



-- This command will delete a table.
drop table myFirstTable;

-- This command will add a new column to an existing table
alter table myFirstTable
add fourthColumn varchar(50);

-- This command will modify an existing column from an existing table
alter table myFirstTable
alter column firstColumn varchar(50) not null;

-- This command will remove a column from an existing table
alter table myFirstTable
drop column fourthColumn;

-- This command will rename a table.
EXEC sp_rename 'newNameForTable', 'myFirstTable'; -- This is from TSQL's syntax

-- ============================================================== QUERYING DATA

--====
-- CREATE DATA / INSERTION OF DATA

-- This command inserts data into a Table.
insert into myFirstTable (firstColumn, secondColumn, thirdColumn)
values ('firstColumnText', 5.5, 5);

-- You can mess with the order of the columns, but ensure you provide all the not null field's values.
insert into myFirstTable (thirdColumn, Id, secondColumn, firstColumn)
values (10, 2, 7.8, 'this is a varchar');

--====
-- READ DATA
-- This command retrieves data from a table.
select firstColumn, secondColumn from myFirstTable;

-- This command retrieves data from a table using ALIASES.
select firstColumn as FirstName, secondColumn as LastName from myFirstTable;

-- This command retrieves EVERYTHING from a table.
select * from myFirstTable;

--====
-- UPDATE/MODIFY DATA
-- This command will update an existing entry in a table.
update myFirstTable
set firstColumn = 'updated value 2',
	secondColumn = 50.4
where Id = 1;

--====
-- DELETE DATA
delete from myFirstTable
where Id = 1;