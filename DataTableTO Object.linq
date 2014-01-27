<Query Kind="Statements">
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

public List<object> ShowMessage2(DataTable dtInput)
    {
        List<object> objectList = new List<object>();

        foreach(DataRow dr in dtInput.Rows)
        {
            MyObj newObj = new MyObj();
            newObj.ID = Convert.ToInt32(dr["ID"]);  // Beware of the possible conversion errors due to type mismatches
            newObj.Name = dr["Name"].ToString();

            objectList.Add(newObj);
        }
        return objectList;
    }

public class MyObj
{
    public int ID { get; set; }
    public string Name { get; set; }        
}