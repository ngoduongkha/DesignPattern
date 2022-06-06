import java.util.HashMap;

public class AttendeeFactory {
    private static final HashMap<String, AttendeeImpl> attendees = new HashMap();
    public static Attendee getAttendee(String name){
        AttendeeImpl attendeeImpl=  attendees.get(name);
        if (attendeeImpl==null){
            attendeeImpl = new AttendeeImpl(name);
            attendees.put(name, attendeeImpl);
            System.out.println("Người tham dự mới: " + name);
        }
        return attendeeImpl;
    }
}
