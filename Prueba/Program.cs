

string[] farudulentOrderIDs= new string[3];

farudulentOrderIDs[0]= "A123";
farudulentOrderIDs[1]= "A123";
farudulentOrderIDs[2]= "A123"; 


foreach(var item in farudulentOrderIDs)
{
    Console.WriteLine(item);
}


//string[] datos = new string['B123','C234','A345','C15','B177','G3003', 'C235', 'B179'];

///string[] datos = new string[8];

string[] datos = {"B123","C234","A345","C15","B177","G3003", "C235", "B179"};



foreach(var item in datos)
{
    if (item.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}


}








