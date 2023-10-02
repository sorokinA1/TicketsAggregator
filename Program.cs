using TicketsAggregatorApp;
using TicketsAggregatorApp.TicketsAggregation;

const string TicketsFolder = @"/Users/artem/Desktop/Tickets";

try
{
    var ticketsAggregator = new TicketsAggregator(
        TicketsFolder,
        new FileWriter(),
        new DocumentsFromPdFsReader());
    ticketsAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Exception occured. Exception message: {ex.Message}");
}

/*
 *
 */