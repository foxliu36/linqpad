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
	//http://msdn.microsoft.com/zh-tw/library/bb387089.aspx
	XElement n = new XElement("Contacts",
        new XElement("Contact",
            new XElement("Name", "Patrick Hines"), 
            new XElement("Phone", "206-555-0144"),
            new XElement("Address",
                new XElement("Street1", "123 Main St"),
                new XElement("City", "Mercer Island"),
                new XElement("State", "WA"),
                new XElement("Postal", "68042")
            )
        )
    );
	Console.WriteLine(n);
	
	XElement n1 = new XElement("Cost", 324.50);
	Console.WriteLine(n1);
	
	// Create a tree with a child element.
	XElement xmlTree1 = new XElement("Root",
		new XElement("Child1", 1)
	);
	
	// Create an element that is not parented.
	XElement child2 = new XElement("Child2", 2);
	
	// Create a tree and add Child1 and Child2 to it.
	XElement xmlTree2 = new XElement("Root",
							xmlTree1.Element("Child1"),
							child2
	);
	Console.WriteLine(xmlTree2);
	// Compare Child1 identity.
	Console.WriteLine("Child1 was {0}",
		xmlTree1.Element("Child1") == xmlTree2.Element("Child1") ?
		"attached" : "cloned");
	
	// Compare Child2 identity.
	Console.WriteLine("Child2 was {0}",
		child2 == xmlTree2.Element("Child2") ?
		"attached" : "cloned");
}

// Define other methods and classes here
