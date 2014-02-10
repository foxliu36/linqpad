<Query Kind="Program">
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

void Main()
{
	var data = (from q in dt01.AsEnumerable()

                            select new 
                            {
                                EmpCNo = "#" + q.Field<string>("EMPLOYEE_ID").PadLeft(10, '0'),
                                Date = q.Field<DateTime>("DATE_TIME_MIN").ToString("yyyy-MM-dd"),
                                Time = q.Field<DateTime>("DATE_TIME_MIN").ToString("HH:mm:ss"),
                                Type = q.Field<string>("DATE_TIME_TYPE"),
                                EmpNo = q.Field<string>("EMPLOYEE_EIP")
                            }).Union(
                            from p in dt02.AsEnumerable()
                            select new //??
                            {
                                EmpCNo = "#" + p.Field<string>("EMPLOYEE_ID").PadLeft(10, '0'),
                                Date = p.Field<DateTime>("DATE_TIME_MAX").ToString("yyyy-MM-dd"),
                                Time = p.Field<DateTime>("DATE_TIME_MAX").ToString("HH:mm:ss"),
                                Type = p.Field<string>("DATE_TIME_TYPE"),
                                EmpNo = p.Field<string>("EMPLOYEE_EIP")
                            });
							
	dataGridView1.DataSource = data.ToList();
	
	//dataGridView1.DataSource = data  也沒辦法顯示出來
	//如果select new 後面加物件 和.ToList();改成 .ToList<物件>()
	//解答 http://www.cnblogs.com/yagzh2000/archive/2012/12/03/2799018.html 好像要class 裡面寫成屬性才可以正常顯示
	//dataGridView1.DataSource 無法顯示出來 ??
}



// Define other methods and classes here
public static DataTable LINQToDataTable<T>(IEnumerable<T> linqList) 
{
    var dtReturn = new DataTable();
    PropertyInfo[] columnNameList = null;

    if (linqList == null) return dtReturn;

    foreach (T t in linqList) 
    {
        // Use reflection to get property names, to create table, Only first time, others will follow 
        if (columnNameList == null) 
        {
            columnNameList = ((Type)t.GetType()).GetProperties();

            foreach (PropertyInfo columnName in columnNameList) 
            {
                Type columnType = columnName.PropertyType;

                if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                {
                    columnType = columnType.GetGenericArguments()[0];
                }

                dtReturn.Columns.Add(new DataColumn(columnName.Name, columnType));
            }
        }

        DataRow dataRow = dtReturn.NewRow();

        foreach (PropertyInfo columnName in columnNameList)
        {
            dataRow[columnName.Name] = 
                columnName.GetValue(t, null) == null ? DBNull.Value : columnName.GetValue(t, null);
        }

        dtReturn.Rows.Add(dataRow);
    }

    return dtReturn;
}