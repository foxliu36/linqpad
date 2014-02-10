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

select *
from TB_EB_MENU

select *   --70幾個role
from TB_EB_SEC_ROLE
where 1=1
and MODULE_ID like 'HR' --人資的部分


select u.*, d.* from TB_EB_USER u
join TB_EB_EMPL_DEP d on u.USER_GUID = d.USER_GUID
where 1=1 
--and USER_GUID = '2bc9ca2f-e55d-4f82-b7ab-7649b79ad72b'
and u.NAME like '%汎%'

select  *
from TB_EB_SEC_ROLE_MEMBER --where RM_ID like '15108ff6-3687-480b-904b-e4550c843312'
where 1=1
and ROLE_ID = 'AttendanceManager'

select TOP 10 *
from TB_EB_SEC_PERM
where ROLE_ID = 'AttendanceManager'

select * from TB_EB_JOB_TITLE
where 1=1
and TITLE_ID = 'fc3a6b5a-eaf2-4dab-8d83-4bf75725d4f3'
and  TITLE_NAME like '助理'