import java.util.ArrayList;
import java.util.List;

public class App {
    public static void main(String[] args) throws Exception 
    {
        List<Shape> shapeArray = new ArrayList<>();
        List<Shape> shapeArrayCopy = new ArrayList<>();

        Circle circle = new Circle();
        circle.x = 10;
        circle.y = 20;
        circle.radius = 15;
        circle.color = "red";
        shapeArray.add(circle);

        Circle anotherCircle = (Circle) circle.clone();
        shapeArray.add(anotherCircle);

        Rectangle rectangle = new Rectangle();
        rectangle.width = 10;
        rectangle.height = 20;
        rectangle.color = "blue";
        shapeArray.add(rectangle);

        cloneAndCompare(shapeArray, shapeArrayCopy);
    }

    private static void cloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy) 
    {
        for (Shape shape : shapes) 
        {
            shapesCopy.add(shape.clone());
        }

        for (int i = 0; i < shapes.size(); i++) 
        {
            if (shapes.get(i) != shapesCopy.get(i)) 
            {
                System.out.println(i + ": Khac tham chieu ");
                
                if (shapes.get(i).equals(shapesCopy.get(i))) 
                {   
                    System.out.println(i + ": Nhung giong nhau");
                } 
                else 
                { 
                    System.out.println(i + ": Khong giong nhau ");
                }
            
            } 
            else 
            {
                System.out.println(i + ": Chung bien tham chieu");
            }
        }
    }
}
