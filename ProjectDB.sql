Create Database ProjectDB;

USE ProjectDB;
GO

CREATE TABLE Student
(
	studentNumber INT PRIMARY KEY,
	firstName VARCHAR(50) NOT NULL,
	lastName VARCHAR(50) NOT NULL,
	dateOfBirth DATE,
	age Int,
	gender VARCHAR(20),
	phoneNumber VARCHAR(20),
	address VARCHAR(100)
);

CREATE TABLE Module 
(
	moduleCode VARCHAR(10) PRIMARY KEY,
	moduleName VARCHAR(50) NOT NULL,
	moduleDesc VARCHAR(200) NOT NULL,
	resources VARCHAR(255)
);

CREATE TABLE StudentModule
(
	studentNumber INT,
	moduleCode VARCHAR(10),
	PRIMARY KEY (studentNumber, moduleCode),
	FOREIGN KEY (studentNumber) REFERENCES Student(studentNumber),
	FOREIGN KEY (moduleCode) REFERENCES Module(moduleCode)
);

INSERT INTO Student (studentNumber, firstName, lastName, dateOfBirth, gender, phoneNumber, address)
VALUES
	(1000, 'Thabo', 'Mthembu', '2002-05-15', 22, 'Male', '0821234567', '123 Main Street, Johannesburg'),
    (1001, 'Nomvula', 'Majola', '2003-04-22', 21, 'Female', '0791122334', '112 Rose Lane, Polokwane'),
    (1002, 'Pieter', 'Van der Merwe', '2000-01-03', 24, 'Male', '0813456789', '789 Willow Avenue, Pretoria'),
    (1003, 'Bokang', 'Moloi', '2001-11-12', 23, 'Male', '0835678901', '456 Acacia Road, Durban'),
    (1004, 'Amara', 'Zulu', '2002-08-05', 22, 'Female', '0846789012', '901 Pine Street, Cape Town'),
    (1005, 'Lebo', 'Nkosi', '2001-08-20', 23, 'Female', '0839876543', '456 Oak Avenue, Pretoria'),
    (1006, 'Ingrid', 'Du Plessis', '2000-03-12', 24, 'Female', '0849012345', '234 Cedar Road, Johannesburg'),
    (1007, 'Thabiso', 'Sithole', '2004-06-18', 20, 'Male', '0851234567', '567 Maple Lane, Bloemfontein'),
    (1008, 'Sasha', 'Khumalo', '2003-09-27', 21, 'Female', '0862345678', '890 Birch Street, Port Elizabeth'),
    (1009, 'Lunga', 'Moloi', '2001-12-01', 23, 'Male', '0873456789', '123 Cedar Avenue, East London'),
    (1010, 'Naledi', 'Ngubane', '2003-02-15', 21, 'Female', '0823456789', '321 Protea Road, Durban'),
    (1011, 'Kabelo', 'Mokoena', '2004-07-19', 20, 'Male', '0782345671', '400 Sunflower Street, Johannesburg'),
    (1012, 'Busisiwe', 'Dlamini', '2002-11-23', 22, 'Female', '0845678912', '201 Oak Lane, Cape Town'),
    (1013, 'Sipho', 'Ndlovu', '2001-01-30', 23, 'Male', '0826789123', '307 Pine Road, Durban'),
    (1014, 'Ayanda', 'Mabena', '2000-09-10', 24, 'Female', '0837890123', '150 Willow Avenue, Pretoria'),
    (1015, 'Linda', 'Nkosi', '2002-05-14', 22, 'Female', '0812345670', '555 Rose Lane, Polokwane'),
    (1016, 'Sizwe', 'Zulu', '2004-12-17', 19, 'Male', '0823456780', '690 Maple Avenue, Bloemfontein'),
    (1017, 'Thembeka', 'Khuzwayo', '2003-03-27', 21, 'Female', '0834567890', '240 Birch Lane, Port Elizabeth'),
    (1018, 'Bongani', 'Sibanda', '2002-01-07', 22, 'Male', '0845678901', '139 Palm Street, Johannesburg'),
    (1019, 'Mpumi', 'Madonsela', '2001-05-23', 23, 'Female', '0856789012', '470 Acacia Road, Cape Town'),
    (1020, 'Rethabile', 'Maseko', '2000-06-12', 24, 'Male', '0867890123', '356 Cedar Avenue, Durban'),
    (1021, 'Zandile', 'Ndlovu', '2002-04-18', 22, 'Female', '0878901234', '274 Willow Lane, Pretoria'),
    (1022, 'Thandeka', 'Ngcobo', '2001-08-09', 23, 'Female', '0835678902', '126 Rose Lane, Polokwane'),
    (1023, 'Siphiwe', 'Zwane', '2003-12-21', 20, 'Male', '0812345679', '332 Acacia Avenue, Johannesburg'),
    (1024, 'Jabu', 'Mkhize', '2004-05-03', 20, 'Male', '0825678912', '145 Oak Street, Durban'),
    (1025, 'Lindiwe', 'Hlongwane', '2002-07-14', 22, 'Female', '0791234567', '672 Palm Road, East London'),
    (1026, 'Kwanele', 'Mahlangu', '2001-10-05', 23, 'Male', '0839012345', '543 Protea Lane, Port Elizabeth'),
    (1027, 'Sanele', 'Moyo', '2000-11-16', 24, 'Female', '0841234567', '809 Cedar Avenue, Pretoria'),
    (1028, 'Nomfundo', 'Mtshali', '2003-02-06', 21, 'Female', '0783456781', '128 Willow Street, Bloemfontein'),
    (1029, 'Tebogo', 'Moloto', '2000-09-27', 24, 'Male', '0793456789', '650 Acacia Road, Johannesburg'),
    (1030, 'Noluthando', 'Sibiya', '2004-10-13', 19, 'Female', '0864567890', '731 Birch Lane, Polokwane'),
    (1031, 'Mpho', 'Maphosa', '2001-03-21', 23, 'Male', '0842345678', '292 Pine Avenue, Cape Town'),
    (1032, 'Phindile', 'Luthuli', '2003-07-10', 21, 'Female', '0811234569', '917 Palm Road, Durban'),
    (1033, 'Sandile', 'Radebe', '2002-11-05', 22, 'Male', '0835678912', '555 Oak Avenue, Pretoria'),
    (1034, 'Tshepo', 'Shabalala', '2000-04-30', 24, 'Male', '0826789012', '209 Cedar Lane, Bloemfontein'),
    (1035, 'Asanda', 'Gumede', '2004-06-08', 20, 'Female', '0867890123', '478 Birch Avenue, East London');

INSERT INTO Module (moduleCode, moduleName, moduleDesc, resources)
VALUES
    ('ENG181', 'English', 'English language fundamentals for first-year students', 'https://www.youtube.com/watch?v=YgKvMf3aolc , https://www.youtube.com/watch?v=O3kg_dWkmCA'),
    ('MAT181', 'Mathematics', 'Basic mathematics for first-year students', 'https://www.youtube.com/watch?v=ouUaxWVJNSI , https://www.youtube.com/watch?v=0oGJTQCy4cQ'),
    ('PRG181', 'Programming I', 'Introduction to programming for first-year students', 'https://www.youtube.com/watch?v=gfkTfcpWqAY , https://www.youtube.com/watch?v=wxznTygnRfQ'),
    ('PRG281', 'Programming II', 'Advanced programming concepts for second-year students', 'https://www.youtube.com/watch?v=gfkTfcpWqAY , https://www.youtube.com/watch?v=wxznTygnRfQ'),
    ('DBD181', 'Database Development I', 'Introduction to database development for first-year students', 'https://www.youtube.com/watch?v=ztHopE5Wnpc , https://www.youtube.com/watch?v=j09EQ-xlh88'),
    ('DBD281', 'Database Development II', 'Advanced database development concepts for second-year students', 'https://www.youtube.com/watch?v=zsjvFFKOm3c , https://www.youtube.com/watch?v=30W5wjgJR08'),
    ('LPR181', 'Linear Programming', 'Introduction to linear programming', 'https://www.youtube.com/watch?v=Bzzqx1F23a8 , https://www.youtube.com/watch?v=kpzIxQbLhME'),
    ('ETH281', 'Ethics', 'Ethical considerations in computing', 'https://www.youtube.com/watch?v=DLCUn6h7qRo , https://www.youtube.com/watch?v=dpmD6NuM_r0'),
    ('WPR181', 'Web Programming I', 'Introduction to web programming for first-year students', 'https://www.youtube.com/watch?v=G3e-cpL7ofc , https://www.youtube.com/watch?v=VEJesN2tjOI'),
    ('WPR281', 'Web Programming II', 'Advanced web programming concepts for second-year students', 'https://www.youtube.com/watch?v=SBmSRK3feww , https://www.youtube.com/watch?v=DHjqpvDnNGE');

INSERT INTO StudentModule (studentNumber, moduleCode)
VALUES
    (1000, 'DBD181'),
    (1000, 'MAT181'),
    (1000, 'PRG181'),

    (1001, 'LPR181'),
    (1001, 'ETH281'),
    (1001, 'MAT181'),

    (1002, 'ENG181'),
    (1002, 'MAT181'),
    (1002, 'PRG181'),

    (1003, 'LPR181'),
    (1003, 'ETH281'),
    (1003, 'MAT181'),

    (1004, 'DBD281'),
    (1004, 'MAT181'),
    (1004, 'PRG181'),

    (1005, 'ENG181'),
    (1005, 'MAT181'),
    (1005, 'WPR181'),

    (1006, 'LPR181'),
    (1006, 'ETH281'),
    (1006, 'WPR281'),

    (1007, 'ENG181'),
    (1007, 'MAT181'),
    (1007, 'PRG181'),

    (1008, 'LPR181'),
    (1008, 'ETH281'),
    (1008, 'PRG281'),

    (1009, 'ENG181'),
    (1009, 'MAT181'),
    (1009, 'WPR181'),

    (1010, 'DBD181'),
    (1010, 'MAT181'),
    (1010, 'PRG181'),

    (1011, 'LPR181'),
    (1011, 'ETH281'),
    (1011, 'MAT181'),

    (1012, 'ENG181'),
    (1012, 'MAT181'),
    (1012, 'PRG181'),

    (1013, 'LPR181'),
    (1013, 'ETH281'),
    (1013, 'MAT181'),

    (1014, 'DBD281'),
    (1014, 'MAT181'),
    (1014, 'PRG181'),

    (1015, 'ENG181'),
    (1015, 'MAT181'),
    (1015, 'WPR181'),

    (1016, 'LPR181'),
    (1016, 'ETH281'),
    (1016, 'WPR281'),

    (1017, 'ENG181'),
    (1017, 'MAT181'),
    (1017, 'PRG181'),

    (1018, 'LPR181'),
    (1018, 'ETH281'),
    (1018, 'PRG281'),

    (1019, 'ENG181'),
    (1019, 'MAT181'),
    (1019, 'WPR181'),

    (1020, 'DBD181'),
    (1020, 'MAT181'),
    (1020, 'PRG181'),

    (1021, 'LPR181'),
    (1021, 'ETH281'),
    (1021, 'MAT181'),

    (1022, 'ENG181'),
    (1022, 'MAT181'),
    (1022, 'PRG181'),

    (1023, 'LPR181'),
    (1023, 'ETH281'),
    (1023, 'MAT181'),

    (1024, 'DBD281'),
    (1024, 'MAT181'),
    (1024, 'PRG181'),

    (1025, 'ENG181'),
    (1025, 'MAT181'),
    (1025, 'WPR181'),

    (1026, 'LPR181'),
    (1026, 'ETH281'),
    (1026, 'WPR281'),

    (1027, 'ENG181'),
    (1027, 'MAT181'),
    (1027, 'PRG181'),

    (1028, 'LPR181'),
    (1028, 'ETH281'),
    (1028, 'PRG281'),

    (1029, 'ENG181'),
    (1029, 'MAT181'),
    (1029, 'WPR181'),

    (1030, 'DBD181'),
    (1030, 'MAT181'),
    (1030, 'PRG181'),

    (1031, 'LPR181'),
    (1031, 'ETH281'),
    (1031, 'MAT181'),

    (1032, 'ENG181'),
    (1032, 'MAT181'),
    (1032, 'PRG181'),

    (1033, 'LPR181'),
    (1033, 'ETH281'),
    (1033, 'MAT181'),

    (1034, 'DBD281'),
    (1034, 'MAT181'),
    (1034, 'PRG181'),

    (1035, 'ENG181'),
    (1035, 'MAT181'),
    (1035, 'WPR181');

BACKUP DATABASE ProjectDB
TO DISK = 'C:\Users\OEM\Desktop\ProjectDB.bak'