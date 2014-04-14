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

var d = (from q in TB_EB_SEC_ROLE_MEMBERs
    	where q.ROLE_ID == "HRManager"
    	select q).First();
		
	Console.WriteLine(d);
	
	XElement xml = d.USER_SET;
	
	//Console.WriteLine(xml.ToString());
	
	XDocument doc = XDocument.Parse(xml.ToString());
	
	var ele = from q in doc.Descendants("Element")
						select q;
	
	IEnumerable<XElement> usernode = from q in doc.Descendants("userId")
                                                select q;
	
	IEnumerable<XElement> jobtitlenode = from q in doc.Descendants("jobTitleId")
                                                select q;
	
	var targetNodess = from q in doc.Descendants("Element")
                               where q.Attribute("type").Value == "jobFunctionOfGroup"
                               select new {
                                   jobFunctionId = q.Descendants("jobFunctionId"),
                                   groupId = q.Descendants("groupId")
                               };
	//Console.WriteLine(ele);						   
	//Console.WriteLine(usernode);
	//Console.WriteLine(jobtitlenode);
	Console.WriteLine(targetNodess);