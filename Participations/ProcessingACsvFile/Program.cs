// See https://aka.ms/new-console-template for more information
string[] linesOfFile = File.ReadAllLines("sales_data_sample.csv");
double totalForShippedItems = 0;

double totalFor2003 = 0;

for (int i = 1; i < linesOfFile.Length; i++)
{
    //                     0             1           2             3          4      5        6      7        8       9        10
    //linesOfFile[0]-"ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE"
    //                  0    1  2   3   4   5              6      7 8   9
    //linesOfFile[1]-"10107,30,95.7,2,2871,2/24/2003 0:00,Shipped,1,2,2003,Motorcycles,95,S10_1678,Land of Toys Inc.,2125557818,897 Long Airport Avenue,,NYC,NY,10022,USA,NA,Yu,Kwai,Small"
    string currentLine = linesOfFile[i];
    string[] pieces = currentLine.Split(",");
    //pieces[0]-"10107"
    //pieces[1]-"30"
    //pieces[2]-"95.7"
    string status = pieces[6];
    double sales = Convert.ToDouble(pieces[4]);
    if (status == "Shipped")
    {
        totalForShippedItems += Convert.ToDouble(pieces[4]); 
   
    }

    if (pieces[9] == "2003") // if(Convert.ToInt32(pieces[9]) == 2003)
    {
        totalFor2003 += sales;
    }

    //Console.WriteLine($"{i}:{status}");

}

Console.WriteLine($"The total for all shipped items is {totalForShippedItems.ToString("C")}");
Console.WriteLine($"The total sales for 2003 is {totalFor2003.ToString("C")}");