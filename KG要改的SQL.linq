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

select c.f_smid, sum(w.f_money)
from tbConstruction as c
join tbwork as w on c.f_workid = w.f_workid
where w.f_closedate between '2013/12/01' and '2013/12/31'
group by c.f_smid