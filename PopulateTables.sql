-- DVDSYS.sql may 2021

-- Delete From

DELETE FROM TRANSACTIONS;
DELETE FROM RENTALITEMS;
DELETE FROM DVDs;
DELETE FROM MEMBERS;
DELETE FROM CATEGORIES;
DELETE FROM AGERATINGS;
DELETE FROM COUNTIES;
DELETE FROM Genres;

PROMPT Populate Conties;

--Insert data into counties

INSERT INTO counties
VALUES ('CE', 'CLARE');
INSERT INTO counties
VALUES ('CK', 'CORK');
INSERT INTO counties
VALUES ('CN', 'CAVAN');
INSERT INTO counties
VALUES ('CW', 'CARLOW');
INSERT INTO counties
VALUES ('DL', 'DONEGAL');
INSERT INTO counties
VALUES ('GY', 'GALWAY');
INSERT INTO counties
VALUES ('ck', 'CORK');
INSERT INTO counties
VALUES ('KE', 'KILDARE');
INSERT INTO counties
VALUES ('KK', 'KILKENNY');
INSERT INTO counties
VALUES ('KY', 'KERRY');
INSERT INTO counties
VALUES ('LD', 'LONGFORD');
INSERT INTO counties
VALUES ('LH', 'LOUTH');
INSERT INTO counties
VALUES ('LK', 'LIMERICK');
INSERT INTO counties
VALUES ('LM', 'LEITRIM');
INSERT INTO counties
VALUES ('LS', 'LAOIS');
INSERT INTO counties
VALUES ('MH', 'MEATH');
INSERT INTO counties
VALUES ('MN', 'MONAGHAN');
INSERT INTO counties
VALUES ('MO', 'MAYO');
INSERT INTO counties
VALUES ('OY', 'OFFALY');
INSERT INTO counties
VALUES ('RN', 'ROSCOMMON');
INSERT INTO counties
VALUES ('SO', 'SLIGO');
INSERT INTO counties
VALUES ('TN', 'TIPPERARY');
INSERT INTO counties
VALUES ('WD', 'WATERFORD');
INSERT INTO counties
VALUES ('WH', 'WESTMEATH');
INSERT INTO counties
VALUES ('WW', 'WICKLOW');
INSERT INTO counties
VALUES ('WX', 'WEXFORD');

PROMPT Populate Genres;

--Insert Into Genres

INSERT INTO Genres
VALUES ('RC','ROMANCE');
INSERT INTO Genres
VALUES ('HR','HORROR');
INSERT INTO Genres
VALUES ('CM','COMEDY');

PROMPT Populate Categories;

--Insert data into Categories

INSERT INTO Categories 
VALUES ('NR','New Release',8.50);
INSERT INTO Categories 
VALUES ('OR','Old Release',5.00);
INSERT INTO Categories 
VALUES ('CH','Children',2.00);

PROMPT Populate Ageratings;

--Insert data into Ageratings

INSERT INTO Ageratings 
VALUES ('G','General Audience');
INSERT INTO Ageratings
VALUES ('PG','Parental Guidance Suggested');
INSERT INTO Ageratings 
VALUES ('PG13','Parents Strongly Suggested');
INSERT INTO Ageratings 
VALUES ('R','Restricted');
INSERT INTO Ageratings 
VALUES ('NC17','Adults Only');

PROMPT Populate Members;

-- Insert into members
INSERT INTO members 
VALUES (1,'James','Mary','14DreamerRoad','Limerick','LK','15-APR-2020','0873841093','1234','A');
INSERT INTO members
VALUES (2,'John','Patricia','772MayWeather','MysticTown','KY','16-APR-2021','0873841095','1159','A');
INSERT INTO members
VALUES (3,'Robert','Jennifer','12AsusManor','Tralee','CK','17-APR-2021','0873841096','1162','A');

PROMPT Populate DVDS;

--Insert data into DVD  

INSERT INTO DVDS 
VALUES (1,'HR','NR',200,'G','Tenet','Christopher Nolan','O');
INSERT INTO DVDS 
VALUES (2,'RC','CH',180,'PG','Barney','tom smith','A');
INSERT INTO DVDS 
VALUES (3,'HR','OR',180,'R','Psycho','blah blah','A');
INSERT INTO DVDS 
VALUES (4,'CM','NR',150,'PG13','Brides Maids','blah blahtwo','A');

PROMPT Populate Transactions;

--Insert data into Transactions

INSERT INTO TRANSACTIONS
VALUES(1,3,'27-APR-2021','28-APR-2021',8.50);

PROMPT Populate RentalItems;

--Insert data into RentalItems 

INSERT INTO RentalItems
VALUES(1,1,'28-APR-2021',0);

-- commit changes
COMMIT;

