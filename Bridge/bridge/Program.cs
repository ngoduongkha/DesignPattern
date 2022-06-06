using bridge;

public class Program
{
    static void Main(string[] args)
    {
        /*Circle circleRed = new Circle(new Red());
        Circle circleGreen = new Circle(new Green());
        Rectangle rectangleRed = new Rectangle(new Red());
        Rectangle rectangleGreen = new Rectangle(new Green());
        circleRed.drawAndColor();
        circleGreen.drawAndColor();
        rectangleRed.drawAndColor();
        rectangleGreen.drawAndColor();*/
        TimeSliced timeSlicedWindow = new TimeSliced(new WindowPTS());
        TimeSliced timeSlicedUnix = new TimeSliced(new UnixPTS());
        Preemptive preemptiveWindow = new Preemptive(new WindowPTS());
        Preemptive preemptiveUnix = new Preemptive(new UnixPTS());
        timeSlicedWindow.Run();
        timeSlicedUnix.Run();
        preemptiveWindow.Run();
        preemptiveUnix.Run();

    }
}