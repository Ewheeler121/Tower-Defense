using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Path MyPath;
    public int currentDestination;
    public float Speed = 2;
    public float WaypointAcceptableError = 0.01f;

    // Start is called before the first frame update
    void Start() {
        currentDestination = 0;
        MyPath = GameObject.Find("Path").GetComponent<Path>();
    }

    // Update is called once per frame
    void Update() {
        if (currentDestination >= MyPath.Waypoints.Length) return;

        transform.position = Vector3.MoveTowards(transform.position, MyPath.Waypoints[currentDestination].position, Speed * Time.deltaTime);
        transform.LookAt(MyPath.Waypoints[currentDestination].position);

        if (Vector3.Distance(transform.position, MyPath.Waypoints[currentDestination].position) <= WaypointAcceptableError) {
            currentDestination++;
        }

    }
}
