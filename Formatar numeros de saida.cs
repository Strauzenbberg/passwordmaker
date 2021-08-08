int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");
/*
Saída
Invoice Number: 1201
   Measurement: 25.457 mg
     Sub Total: ¤2,750.00
           Tax: 15.83 %
     Total Due: ¤3,185.19
	 */
	 