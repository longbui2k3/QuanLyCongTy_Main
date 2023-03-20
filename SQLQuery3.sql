use QLCT
CREATE TABLE TimeLog (
    TimeLogID int IDENTITY(1,1) PRIMARY KEY  ,
    EmployeeID char(50) NOT NULL,
    CheckinTime DATETIME NOT NULL,
    CheckoutTime DATETIME,
)

CREATE TABLE LeaveRequest (
    LeaveRequestID nvarchar(50)  ,
    EmployeeID nvarchar(50) NOT NULL,
    LeaveReason nvarchar(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    Status nvarchar(20) NOT NULL,
    )
ALTER TABLE TimeLog ADD TotalWorkHours FLOAT;
Select *from TimeLog