string[] fraudulentOrderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235","B179" ];

string fradulentIDs = "";

foreach (string id in fraudulentOrderIDs )
{
    if ( id.StartsWith("B") )
    {
        fradulentIDs += id;
        Console.WriteLine($"{id} might be fraudulent it starts with B");
    }
}