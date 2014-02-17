<Query Kind="SQL">
  <Connection>
    <ID>0f7f090b-371a-4c23-917e-2e833dd307f5</ID>
    <Persist>true</Persist>
    <Server>172.26.100.8</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAARn2gSMScA0K9YR2dJBhZagAAAAACAAAAAAADZgAAwAAAABAAAAC9q2wk0Xuir5ysKBbBnHG6AAAAAASAAACgAAAAEAAAAAkP23bsCGCM7Yf5QV5MQNIIAAAA/2QrbMQWu1kUAAAA4Vr9hoQjaIPPJuUb7KCkd1Uj8vE=</Password>
    <Database>UOF</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

insert into TB_HR_CLOCKTIME (ID, EMPLOYEE_ID, EMPLOYEE_EIP, DATE_TIME, TERMINAL_ID, VERIFICATION_SOURCE)

select ID,  EmployeeID, UserID, DateTime,
TerminalID, VerificationSource
from DoorLog17
where UserID <> '0'
and DateTime >= '2014/1/17' 
and DateTime <= '2014/1/31' 
and ID not in (
select ID from TB_HR_CLOCKTIME 
where DATE_TIME >= '2014/1/17' and DATE_TIME <= '2014/1/31'
)