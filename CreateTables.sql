-- DVDSYS.sql may 2021

-- Drop tables

DROP TABLE RENTALITEMS;
DROP TABLE TRANSACTIONS;
DROP TABLE DVDs;
DROP TABLE MEMBERS;
DROP TABLE CATEGORIES;
DROP TABLE AGERATINGS;
DROP TABLE COUNTIES;
DROP TABLE GENRES;

-- Create Tables

PROMPT Create Table Conties;

CREATE TABLE Counties(
County_Code char(2),
Description VARCHAR2(20) NOT NULL,
CONSTRAINT PK_Counties PRIMARY KEY (County_Code)
);

PROMPT Create Table Genres;

CREATE TABLE Genres(
Genre_Code Char(2),
Description VARCHAR2(20) NOT NULL,
CONSTRAINT PK_Genres PRIMARY KEY (Genre_Code)
);

PROMPT Create Table Categories;

CREATE TABLE Categories (
Cat_Code char(2) NOT NULL,
Description VARCHAR(30) NOT NULL,
Rate DECIMAL(5,2) NOT NULL,
CONSTRAINT pk_Categories PRIMARY KEY (cat_Code)
);

PROMPT Create Table Ageratings;

CREATE TABLE Ageratings(
Ar_Code char(4) NOT NULL,
Description VARCHAR(30) NOT NULL,
CONSTRAINT pk_Ageratings PRIMARY KEY (ar_Code)
);

PROMPT Create Table Members;

CREATE TABLE MEMBERS(
Cust_ID NUMERIC(3) NOT NULL,
First_Name VARCHAR2(25) NOT NULL,
Last_Name VARCHAR2(25) NOT NULL,
Address VARCHAR2(25) NOT NULL,
Town VARCHAR2(25) NOT NULL,
County_Code CHAR(2) NOT NULL,
Date_of_reg DATE NOT NULL,
PhoneNumber VARCHAR2(15) NOT NULL,
Pin VARCHAR2(4) NOT NULL,
Status char(1) NOT NULL,
CONSTRAINT pk_members PRIMARY KEY(cust_ID),
CONSTRAINT fk_members_counties FOREIGN KEY(County_Code) REFERENCES Counties(County_Code)
);

PROMPT Create Table DVDS;

CREATE TABLE DVDS(
Dvd_ID NUMERIC(4) NOT NULL,
Genre_Code char(2) NOT NULL,
Cat_Code char(2) NOT NULL,
Run_time numeric(3) NOT NULL,
Ar_Code char(4) NOT NULL,
Title VARCHAR2(35) NOT NULL,
Director VARCHAR2(35) NOT NULL,
Status char(1) NOT NULL,
CONSTRAINT pk_DVDS PRIMARY KEY(dvd_ID),
CONSTRAINT fk_Categories FOREIGN KEY (cat_Code) REFERENCES Categories(cat_Code),
CONSTRAINT fk_Ageratings FOREIGN KEY (ar_Code) REFERENCES Ageratings(ar_Code)
);

PROMPT Create Table Transactions;

CREATE TABLE TRANSACTIONS(
Rental_ID NUMERIC(3) NOT NULL,
Cust_ID NUMERIC(3) NOT NULL,
Rent_Date DATE NOT NULL,
Return_Date DATE NOT NULL,
Total DECIMAL(5,2) NOT NULL,
CONSTRAINT pk_TRANSACTIONS PRIMARY KEY(rental_ID),
CONSTRAINT fk_Members FOREIGN KEY (cust_ID) REFERENCES members(cust_ID)
);

PROMPT Create Table RentalItems;

CREATE TABLE RentalItems(
Rental_ID NUMERIC(3) NOT NULL,
Dvd_ID NUMERIC(3) NOT NULL,
Return_Date DATE    ,
Fine DECIMAL(5,2) NOT NULL,
CONSTRAINT pk_RentalItems PRIMARY KEY (rental_ID,dvd_ID)
);


