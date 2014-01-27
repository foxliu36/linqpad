<Query Kind="SQL">
  <Connection>
    <ID>b2c801d0-e9b9-475a-ab2d-c76bd8264b47</ID>
    <Persist>true</Persist>
    <Server>KDSQL</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>96002</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAARn2gSMScA0K9YR2dJBhZagAAAAACAAAAAAADZgAAwAAAABAAAADhoI0x3ZpcAhRQ99BDluShAAAAAASAAACgAAAAEAAAAFjAF1LJ9y2Af7cnvlThvNwQAAAA8vSOJxxtbqatwd/vBxIy9hQAAAAAno6uEaXDQrBptKtK+4HXYOIo4g==</Password>
    <Database>KG</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

 select u.f_userid,u.f_username
  ,sum(wt.f_moneybyin/aa.countamt)  as f_amt ,sum(wt.f_moneyByOut/aa.countamt) as f_amtout 
   from 
   (
   	select f_workid,count(f_workid) as countamt
	from tbConstruction
	group by f_workid
	) aa
	inner join tbConstruction c on aa.f_workid = c.f_workid
	inner join dbo.tbWork w on c.f_workid = w.f_workid
	inner join dbo.tbUser u on c.f_smid = u.f_userid
	inner join dbo.tbWorkType wt on wt.f_typeid = w.f_worktype
	where w.f_staus = '完工'
	and w.f_closedate between '2013/11/1' and '2013/11/31' 
	 group by u.f_userid,u.f_username
	 