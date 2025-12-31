CREATE DATABASE PrivateHospital;

USE PrivateHospital;

CREATE TABLE Patients (
    Name NVARCHAR(100),
    Address NVARCHAR(255),
    County NVARCHAR(100),
    Age INT,
	Gender NVARCHAR(10),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
	PatientNumber INT
);

CREATE TABLE Doctors (
    Name NVARCHAR(100),
    Address NVARCHAR(255),
    County NVARCHAR(100),
    Age INT,
	Gender NVARCHAR(10),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    Pay DECIMAL(10, 2)
);

CREATE TABLE Nurses (
    Name NVARCHAR(100),
    Address NVARCHAR(255),
    County NVARCHAR(100),
    Age INT,
	Gender NVARCHAR(10),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    Hours INT
);


GO
CREATE PROCEDURE GetAllDoctors
AS
BEGIN
    SELECT * FROM Doctors;
END;

GO
CREATE PROCEDURE GetAllNurses
AS
BEGIN
    SELECT * FROM Nurses;
END;

GO
CREATE PROCEDURE GetAllPatients
AS
BEGIN
    SELECT * FROM Patients;
END;

GO
CREATE PROCEDURE GetMaleNurses
AS
BEGIN
    SELECT * FROM Nurses WHERE Gender = 'Male';
END;

GO
CREATE PROCEDURE GetPatientsAbove25
AS
BEGIN
    SELECT * FROM Patients WHERE Age > 25;
END;

GO
CREATE PROCEDURE GetDoctorsWithHighPay
AS
BEGIN
    SELECT * FROM Doctors WHERE Pay > 100000;
END;

GO
CREATE PROCEDURE GetNursesWorkingOver40Hours
AS
BEGIN
    SELECT * FROM Nurses WHERE Hours > 40;
END;

INSERT INTO Nurses (Name, Address, County, Age, Gender, Phone, Email, Hours)
VALUES ('Nurse Alice Johnson', '789 Pine St', 'Dublin', 35, 'Female', '555-123-4567', 'alice.johnson@example.com', 40);


INSERT INTO Doctors (Name, Address, County, Age, Gender, Phone, Email, Pay)
VALUES ('Dr. Jane Smith', '456 Elm St', 'Dublin', 45, 'Female', '098-765-4321', 'jane.smith@example.com', 120000.00);

