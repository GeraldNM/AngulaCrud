CREATE TABLE Employee
(
 EmployeeId BIGINT IDENTITY(1,1) PRIMARY KEY, 
  FirstName VARCHAR(200) ,
  Surname VARCHAR(200) ,
  IdentityType INT,
  IdentityNumber VARCHAR(50) ,
  DateOfBirth DATETIME



)


INSERT INTO Employee
SELECT 'Bloogs', 'Daley', 1, '20005', '1900-02-06'



select * from  Employee


