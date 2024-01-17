public class Event
{
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string CreatorName { get; set; } 

    public Event(DateTime date, string description, string creatorName)
    {
        Date = date;
        Description = description;
        CreatorName = creatorName;
    }
}
