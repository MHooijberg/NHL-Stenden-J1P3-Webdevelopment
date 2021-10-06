package objecten;

import wiskunde.Vec3;
import wiskunde.Ray;
import pixelinfo.Color;

public class Plane {

private boolean checkered;

    public Plane(boolean checkered, float height, Color color, float reflectivity) {

    }

    public Vec3 calculateIntersection(Ray ray) {
    throw new UnsupportedOperationException();

    }

    public Vec3 getNormalAt(Vec3 point) {
    throw new UnsupportedOperationException();

    }

    public Color getColor() {
        return color;
    }

}