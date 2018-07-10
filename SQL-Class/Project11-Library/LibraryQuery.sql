CREATE DATABASE LibraryTest;

USE LibraryTest;
GO

CREATE TABLE PUBLISHER (
	Name VARCHAR(50) PRIMARY KEY NOT NULL,
	PublisherAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL
);

CREATE TABLE BOOK (
	BookId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) NOT NULL CONSTRAINT FK_Publisher_Name FOREIGN KEY REFERENCES PUBLISHER(Name) ON UPDATE CASCADE ON DELETE CASCADE,
);

CREATE TABLE BOOK_AUTHORS (
	BookId INT NOT NULL CONSTRAINT FK_Authors_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(50) NOT NULL
);

CREATE TABLE LIBRARY_BRANCH (
	BranchId INT PRIMARY KEY NOT NULL IDENTITY(200,1),
	BranchName VARCHAR(50) NOT NULL,
	BranchAddress VARCHAR(50) NOT NULL
);

CREATE TABLE BORROWER (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Name VARCHAR(50) NOT NULL,
	BorrowerAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL
);

CREATE TABLE BOOK_LOANS (
	BookId INT NOT NULL CONSTRAINT FK_Loans_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT FK_Loans_BranchId FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT FK_Loans_CardNo FOREIGN KEY REFERENCES BORROWER(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL
);

CREATE TABLE BOOK_COPIES (
	BookId INT NOT NULL CONSTRAINT FK_Copies_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT FK_Copies_BranchId FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	No_Of_Copies INT NOT NULL
);

INSERT INTO PUBLISHER
	(Name, PublisherAddress, Phone)
	Values
	('Lil Wayne', '123 Fake Road', '123-456-3434'),
	('Juice Wrld', '124 Fake Road', '123-454-4545'),
	('CDPR', '345 Real Road', '156-789-7878'),
	('EA', '565 Real Road', '345-678-9090'),
	('Publisher', '567 fake road', '876-567-1212'),
	('Coco', '356 Hunter Road', '456-123-1234'),
	('Laptop', '200 Laptop Street', '345-900-9090'),
	('Spider-man', '300 New York Lane', '145-800-5676'),
	('Batman', '5000 Something Road', '378-123-8080'),
	('Monster', '3444 Alien Road', '145-678-3535'),
	('Blarg', '322 Nothing Lane', '456-700-4545')
;

INSERT INTO BOOK
	(Title, PublisherName)
	VALUES
	('The Lost Tribe', 'Lil Wayne'),
	('CDPR = GOOD EA = BAD', 'CDPR'),
	('Something', 'EA'),
	('How to make a good book', 'Publisher'),
	('Monster energy drinks are good', 'Monster'),
	('Makes you feel like Batman', 'Batman'),
	('Reddit sucks', 'Spider-man'),
	('How to be a dog', 'Coco'),
	('How to be a laptop', 'Laptop'),
	('How to rap', 'Juice Wrld'),
	('Halo: The Fall of Reach', 'Lil Wayne'),
	('The hound of the baskervilles', 'Spider-man'),
	('Monster coffees are great', 'Batman'),
	('This book sucks', 'CDPR'),
	('TW3', 'CDPR'),
	('BF2', 'EA'),
	('Reddit is good', 'Laptop'),
	('League', 'Juice Wrld'),
	('Garbage', 'Monster'),
	('Fortnite is the best game in the world!?', 'Batman'),
	('Safeway is a good store', 'Publisher'),
	('Walmart is weird but funny', 'Publisher')
;

INSERT INTO BOOK_AUTHORS
	(BookId, AuthorName)
	VALUES
	(1, 'Lil Wayne'),
	(2, 'Juice Wrld'),
	(3, 'Post Malone'),
	(4, 'Eminem'),
	(5, 'Kendrick Lamar'),
	(6, 'Lil Uzi Vert'),
	(7, 'Jarren Benton'),
	(8, 'Hopsin'),
	(9, 'Joyner Lucas'),
	(10, 'Scarlord'),
	(11, 'XXXTentacion'),
	(12, 'Drake'),
	(13, 'Lil Baby'),
	(14, 'Vince Staples'),
	(15, 'Stephen King'),
	(16, 'Stephen King'),
	(17, 'Jaden Smith'),
	(18, 'Tyler the Creator'),
	(19, 'Tech N9ne'),
	(20, 'Childish Gambino'),
	(21, 'Lil Skies'),
	(22, 'Kanye West')
;

INSERT INTO BORROWER
	(Name, BorrowerAddress, Phone)
	VALUES
	('Bob', '123 Fake Lane', '123-456-8989'),
	('Chris', '345 Pineapple Road', '456-789-0909'),
	('Josh', '342 Apple Road', '234-345-3434'),
	('Zach', '456 Orange Lane', '234-456-3435'),
	('Iris', '234 Something Lane', '123-545-2323'),
	('Lil Wayne', '567 Alien Road', '456-789-4343'),
	('Larry', '567 Nothing Street', '345-675-5656'),
	('Han Solo', '364 Wrong Road', '145-890-0808')
;

INSERT INTO LIBRARY_BRANCH
	(BranchName, BranchAddress)
	VALUES
	('Sharpstown', '456 Sharpstown Road'),
	('Central', '476 Central Street'),
	('Best', '342 Best Street'),
	('New York', '145 York Road')
;

INSERT INTO BOOK_COPIES
	(BookId, BranchId, No_Of_Copies)
	VALUES
	(1, 200, 4),
	(2, 200, 5),
	(3, 200, 23),
	(4, 200, 45),
	(5, 200, 13),
	(6, 200, 15),
	(7, 200, 16),
	(8, 200, 34),
	(9, 200, 90),
	(10, 200, 9000),
	(11, 201, 34),
	(12, 201, 23),
	(13, 201, 12),
	(14, 201, 4),
	(15, 201, 6),
	(16, 201, 9),
	(17, 201, 90),
	(18, 201, 67),
	(19, 201, 76),
	(20, 201, 87),
	(21, 202, 90),
	(22, 202, 8000),
	(1, 202, 45),
	(2, 202, 35),
	(3, 202, 23),
	(4, 202, 78),
	(5, 202, 56),
	(6, 202, 45),
	(7, 202, 24),
	(8, 202, 23),
	(9, 203, 23),
	(10, 203, 23),
	(11, 203, 5),
	(12, 203, 7),
	(13, 203, 4),
	(14, 203, 9),
	(15, 203, 8),
	(16, 203, 6),
	(17, 203, 5),
	(18, 203, 4)
;

CREATE PROCEDURE dbo.getLibraryData
AS
/*1*/
SELECT No_Of_Copies
FROM BOOK
INNER JOIN BOOK_COPIES ON BOOK.BookId = BOOK_COPIES.BookId
INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE Title='The Lost Tribe' AND BranchName='Sharpstown';

/*2*/
SELECT BranchName, No_Of_Copies
FROM BOOK
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookId = BOOK.BookId
INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE Title='The Lost Tribe';

/*3*/
SELECT Name
FROM BORROWER B
WHERE NOT EXISTS 
	(SELECT *
	FROM BOOK_LOANS L
	WHERE B.CardNo=L.CardNo);

/*4*/
SELECT B.Title, BO.Name, BO.BorrowerAddress
FROM BOOK B, Borrower BO, BOOK_LOANS BL, LIBRARY_BRANCH LB
WHERE LB.BranchName='Sharpstown' AND LB.BranchId=BL.BranchId AND
BL.DueDate='2008-12-2'AND BL.CardNo=BO.CardNo AND BL.BookId=B.BookId;

/*5*/
SELECT LB.BranchName, COUNT(*)
FROM BOOK_LOANS BL, LIBRARY_BRANCH LB
WHERE BL.BranchId=LB.BranchId
GROUP BY LB.BranchName;

/*6*/
SELECT B.Name, B.BorrowerAddress, COUNT(*)
FROM BORROWER B, BOOK_LOANS BL
WHERE B.CardNo=BL.CardNo
GROUP BY B.CardNo, B.Name, B.BorrowerAddress
HAVING COUNT(*)>5;

/*7*/
SELECT Title, No_Of_Copies
FROM BOOK_AUTHORS
INNER JOIN BOOK ON BOOK_AUTHORS.BookId = BOOK.BookId
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookId = BOOK_AUTHORS.BookId
INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE AuthorName='Stephen King' AND BranchName='Central';

GO

EXEC dbo.getLibraryData
