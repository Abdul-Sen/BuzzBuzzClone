-- SCRIPTS to setup the SQL DB tables (in the correct order)

-- 1
CREATE TABLE Builder(
	Id int NOT NULL IDENTITY(1,1) Primary key,
	BuilderName varchar(100),
	Email varchar(100),
);

-- 2
CREATE TABLE Units (
	Id int not null identity(1,1) primary key,
	FloorSpaceSqft  int not null,
	UnitDesc varchar(200) not null,
	AdditionalInfo varchar(255),
	BedCount int,
	BathCount int,
	UnitNo int,
	Price int not null,
	
);

-- 3
CREATE TABLE Address (
	Id int not null identity(1,1) primary key,
	Country varchar(100),
	State varchar(100),
	StreetName varchar(100),
	StreetNo int
)


-- 4
CREATE TABLE Project (
	Id int not null identity(1,1) primary key,
	minSqft int,
	maxSqft int,
	name varchar(100),
	addressId int,
	CONSTRAINT FK_Address FOREIGN KEY (addressId)
	REFERENCES Address(Id)
);


-- 5
ALTER TABLE Units 
ADD projectId int;

ALTER TABLE Units 
ADD CONSTRAINT FK_Project
FOREIGN KEY (projectId)
REFERENCES Project(Id);