package objecten;

import wiskunde.Ray;
import wiskunde.Vec3;
//import java.awt.Color;

//ToDo: Implement colors
public abstract class Object {
    private Vec3 position;
    private Color color;
    
    public abstract Vec3 calculateIntersection(Ray ray);

    public abstract Vec3 getNormalAt(Vec3 point);

    public Color getColor(){
        return color;
    }
}
