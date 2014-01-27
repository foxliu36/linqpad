<Query Kind="Expression">
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

from  g in TB_EB_GROUPs
join t in TB_EB_JOB_TITLEs
where q.GROUP_NAME.Contains("LEXUS") and 
select q

TB_EB_JOB_TITLEs.Where(p=>p.TITLE_NAME.Contains("練習"))


from u in TB_EB_USERs
join d in TB_EB_EMPL_DEPs on u.USER_GUID equals d.USER_GUID
join t in TB_EB_JOB_TITLEs on d.TITLE_ID equals t.TITLE_ID
join g in TB_EB_GROUPs on d.GROUP_ID equals g.GROUP_ID
where g.GROUP_NAME.Contains("整備") && t.TITLE_NAME.Contains("辦事員")
select new {
	name = u.NAME,
	g = g.GROUP_NAME,
	
}