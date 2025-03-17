using UnityEngine;

public class Path : MonoBehaviour {
    public Transform[] Waypoints;
    public float[] SegmentDistances;

    void Start() {
        SegmentDistances = new float[Waypoints.Length];
        SegmentDistances[0] = 0;
        for (int i = 1; i < SegmentDistances.Length; i++) {
            SegmentDistances[i] = Vector3.Distance(Waypoints[i-1].position, Waypoints[i].position);
        }
    }

    public float GetDistanceRemaining(Vector3 position, int nextWaypoint) {
        float distanceTotal = Vector3.Distance(position, Waypoints[nextWaypoint].position);
        for (int i = nextWaypoint + 1; i < SegmentDistances.Length; i++) {
            distanceTotal += SegmentDistances[i];
        }

        return (distanceTotal);
    }
}
