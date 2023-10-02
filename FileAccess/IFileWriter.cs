namespace TicketsAggregatorApp.TicketsAggregation;

public interface IFileWriter
{
    void Write(string content, params string[] pathParts);
}