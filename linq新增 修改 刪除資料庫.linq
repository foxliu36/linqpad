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
	var data = from q in Sheet101s
				select q;
	//新增
	//var sheet11 = new Sheet101(){
		//Smid = "fox111111",
		//Car = 5
	//};			
	//Sheet101s.InsertOnSubmit(sheet11);
	//Sheet101s.Context.SubmitChanges();
	//Console.WriteLine(data);
	
	//var fix = (from q in TB_HR_CLOCKTIMEs
				//where q.ID == 64538
				//select q).Take(1);
	Console.WriteLine(轉換員編(1000765.ToString()));
	//fix.EMPLOYEE_EIP = "12345";
	//SubmitChanges();
	//foreach(var pp in fix)
	//{
		//pp.Car = 0;
		//pp.EMPLOYEE_EIP = 轉換員編(pp.EMPLOYEE_EIP.ToString());
		//pp.TERMINAL_ID = pp.TERMINAL_ID;
		//Console.WriteLine(pp);
		//Sheet101s.Context.SubmitChanges();
		//TB_HR_CLOCKTIMEs.Context.SubmitChanges();
	//}
	//SubmitChanges();
	//TB_HR_CLOCKTIMEs.Context.SubmitChanges();
	//Console.WriteLine(fix);
	//Console.WriteLine(轉換員編(1000765.ToString()));
}

// Define other methods and classes here
private string 轉換員編(string p_EmployeeID)
        {
            string l_strNumBer = "";
            string l_strChar = "";
            if (p_EmployeeID.Length == 5)//員編五碼者不變
            {
                return p_EmployeeID.Trim();
            }
            else if (p_EmployeeID.Length == 6)//員編五碼者轉換成英文 990465 > A9904
            {
                l_strNumBer = p_EmployeeID.Substring(0, 4);
                l_strChar = p_EmployeeID.Substring(4, 2);
                l_strChar = 數字轉英文(l_strChar, p_EmployeeID.Length);

            }
            else if (p_EmployeeID.Length == 7)//員編五碼者轉換成英文 990465 > A9904
            {
                l_strNumBer = p_EmployeeID.Substring(2, 3);
                l_strChar = p_EmployeeID.Substring(5, 2);
                l_strChar = 數字轉英文(l_strChar, p_EmployeeID.Length);

            }
            p_EmployeeID = l_strChar + l_strNumBer;
            return p_EmployeeID;
        }

        private string 數字轉英文(string p_str,int p_strLenth)
        {
            if (p_strLenth == 6)
            {
                switch (p_str)
                {
                    case "65": return "A";
                    case "66": return "B";
                    case "67": return "C";
                    case "68": return "D";
                    case "69": return "E";
                    case "70": return "F";
                    case "71": return "G";
                    case "72": return "H";
                    case "73": return "I";
                    case "74": return "J";
                    case "75": return "K";
                    case "76": return "L";
                    case "77": return "M";
                    case "78": return "N";
                    case "79": return "O";
                    case "80": return "P";
                    case "81": return "Q";
                    default: return "XX";
                }
            }
            else if (p_strLenth == 7)
            {
                switch (p_str)
                {
                    case "65": return "AA";
                    case "66": return "BA";
                    case "67": return "CA";
                    case "68": return "DA";
                    case "69": return "EA";
                    case "70": return "FA";
                    case "71": return "GA";
                    case "72": return "HA";
                    case "73": return "IA";
                    case "74": return "JA";
                    case "75": return "KA";
                    case "76": return "LA";
                    case "80": return "P";
                    default: return "XX";
                }
            }
            else if (p_strLenth == 4)
            {
                switch (p_str)
                {
                    case "78": return "W";
                    default: return "XX";
                }
            }
            else
            {
                return "XX";
            }
        }
    