package wiskunde;

public class RayHit {
    private Ray ray;
    private Object hitSolid;
    private Vec3 hitPos;
    private Vec3 normal;

    public Ray getRay() {
        return ray;
    }

    public Object getSolid() {
        return hitSolid;
    }

    public Vec3 GetPos() {
        return hitPos;
    }

    public Vec3 GetNorm() {
        return normal;
    }
}
