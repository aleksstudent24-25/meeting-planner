public class Meeting
{
    public DateTime ScheduledTime { get; protected set; }
    public Person Leader { get; protected set; }
    public List<Person> Attendees { get; protected set; }
    public string Topic { get; protected set; }

    public Meeting(DateTime scheduledTime, Person leader, List<Person> attendees, string topic)
    {
        ScheduledTime = scheduledTime;
        Leader = leader;
        Attendees = attendees;
        Topic = topic;
    }
}