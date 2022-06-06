import java.util.Random;

public class main {

    private static final String[] names = {"Quyền", "Tiến", "Thành", "Hòa"};

    public static void main(String[] args) {
        for(int i = 0; i < 10; ++i) {
            AttendeeImpl attendeeImpl = (AttendeeImpl) AttendeeFactory.getAttendee(getRandomName());
            attendeeImpl.setAge(getRandomAge());
            attendeeImpl.listenToConcert();
        }
        System.out.println("------------------------------");
        System.out.println("Chương trình này được đăng tại Freetuts.net");
    }

    private static String getRandomName() {
        int randomName = new Random().nextInt(names.length);
        return names[randomName];
    }

    private static int getRandomAge() {
        return (int)(Math.random()*80);
    }
}