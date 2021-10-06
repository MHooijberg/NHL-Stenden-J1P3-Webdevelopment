package render;

import java.util.concurrent.CopyOnWriteArrayList;

import objecten.Object;
import wiskunde.Ray;
import wiskunde.RayHit;

public class Scene {

    private Camera camera;
    private Light light;
    private CopyOnWriteArrayList<Object> solids;

    public Scene() {

    }

    public void addObject(Object solid) {
    throw new UnsupportedOperationException();

    }

    public RayHit rayCast(Ray ray) {
    throw new UnsupportedOperationException();

    }

    public Camera getCam() {
        return camera;
    }

    public Light getLight() {
        return light;
    }

}