<Query Kind="Statements">
  <Connection>
    <ID>385baeae-8dba-4243-8417-afd99a398c2d</ID>
    <Persist>true</Persist>
    <Server>172.26.100.8</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAARn2gSMScA0K9YR2dJBhZagAAAAACAAAAAAADZgAAwAAAABAAAAA2E5NOKwplgdgRcRhIx0txAAAAAASAAACgAAAAEAAAAOiZ2fSv4S4/aMufWwoWdiwIAAAAYSWi0WMsXXAUAAAAekrtfK6nBBSZ6aK1/d+mFKBKB4I=</Password>
    <Database>UOF</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

	//欄位大小寫注意   join 資料表的先後順序也有差別
	from o in TB_KD_ORDERS 
	join s in TB_REW_SPECIALSALEs on o.OrderNo equals s.ORDERNO
	join sc in TB_REW_SALEDOCs on s.ORDERNO equals sc.ORDERNO
	join c in Customers on o.CustomerId equals c.CustomerID 
	join u in TB_EB_USERs on o.SMId equals u.ACCOUNT 
	join sh in Sheet11s on o.OrderNo equals sh.Orderno  into ddd
	from d1 in ddd.DefaultIfEmpty()
	where o.SaleDay >= Convert.ToDateTime("2013/11/01") && o.SaleDay <= Convert.ToDateTime("2013/11/30")
	select new {
		SMId 	 = o.SMId,
		NAME     = u.NAME,
		BranchId = o.BranchId,
		SectorId = o.SectorId,
		OrderNo = o.OrderNo,
		Name = c.Name,
		CarCod = o.CarCod,
		CarMdl = o.CarMdl,
		SFX = o.SFX,
		EngNo = o.EngNo,
		SaleDay = o.SaleDay,
		OrderDay = o.OrderDay,
		BIG_TYPE = s.BIG_TYPE,
		SPECIAL_TYPE = s.SPECIAL_TYPE,
		M_APPLY_NUM = s.M_APPLY_NUM,
		orderno = sh.Orderno,
		INSURANCE_TYPE = s.INSURANCE_TYPE,
		SUPPORT_TYPE = s.SUPPORT_TYPE
		
	}
