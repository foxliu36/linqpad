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

	select a.*,b.DATE_TIME_MAX, u.ACCOUNT
	,g.GROUP_NAME, t.TITLE_NAME 
	from
	(
	select EMPLOYEE_ID,EMPLOYEE_EIP,MIN(DATE_TIME) as DATE_TIME_MIN 
	from dbo.TB_HR_CLOCKTIME
 	where EMPLOYEE_ID <> '' 
	--and EMPLOYEE_EIP = 'LA201'
  	and  DATE_TIME  >= '2014/01/06' and DATE_TIME  <='2014/01/06 23:59'
   	group by EMPLOYEE_ID,EMPLOYEE_EIP
	) a   
	join
 	(  
 	select EMPLOYEE_ID,EMPLOYEE_EIP,MAX(DATE_TIME) as DATE_TIME_MAX 
	from dbo.TB_HR_CLOCKTIME
 	where EMPLOYEE_ID <> '' 
	--and EMPLOYEE_EIP = 'LA201'
  	and  DATE_TIME  >= '2014/01/06' and DATE_TIME  <='2014/01/06 23:59'
   	group by EMPLOYEE_ID,EMPLOYEE_EIP
	) b
   on a.EMPLOYEE_ID = b.EMPLOYEE_ID
   join TB_EB_USER u
   on b.EMPLOYEE_EIP = u.ACCOUNT
	join TB_EB_EMPL_DEP d 
	on u.USER_GUID = d.USER_GUID
	join TB_EB_GROUP g
	on d.GROUP_ID = g.GROUP_ID
	join TB_EB_JOB_TITLE t
	on d.TITLE_ID = t.TITLE_ID