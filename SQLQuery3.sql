/*use QLCT*/
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
SET IDENTITY_INSERT TimeLog ON
Insert into TimeLog (TimeLogID,EmployeeID ,CheckinTime ,CheckoutTime )values(2, 'NV001', '2020-01-02T08:00:26.527' , '2020-01-02T17:00:26.527') 
SET IDENTITY_INSERT TimeLog OFF

Insert into LeaveRequest values('LR001', 'NV001', N'Bệnh', '2022-12-09', '2022-12-11', N'Ổn định')
select * from LeaveRequest