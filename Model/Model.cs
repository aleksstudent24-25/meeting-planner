public class Model
{
    private List<Meeting> Meetings { get; set; }
    public Model()
    {
        Meetings = new List<Meeting>();
    }

    public void AddMeeting(DateTime scheduledTime, Person leader, List<Person> attendees, string topic)
    {
        Meetings.Add(new Meeting(scheduledTime, leader, attendees, topic));
    }

    public List<Meeting> GetMeetings()
    {
        return Meetings;
    }
}