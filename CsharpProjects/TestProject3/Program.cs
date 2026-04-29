/*
Your work in the security department is focused on finding a pattern for fraudulent orders. You want your code to review past customer orders and identify markers associated with fraudulent orders. Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed. Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID. How can you create a data structure to hold multiple related values?
*/

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");