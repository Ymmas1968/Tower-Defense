using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [Header("Waypoints Settings")]
    public List<Transform> wayPointList;  // Assign in Inspector
    public float speed = 4f;
    public float rotationSpeed = 5f;
    public float reachThreshold = 0.1f; // How close before switching waypoints
    [SerializeField] GameObject enemy;

    private int currentPoint = 0;

    [SerializeField] private WayPointManager wayPointManager;

    private void Start()
    {


        wayPointManager = GameObject.FindGameObjectWithTag("WaypointManager").GetComponent<WayPointManager>();
        wayPointList = wayPointManager.GetWayPoints();  
    }

    void Update()
    {
        if (wayPointList.Count == 0) return;

        Transform target = wayPointList[currentPoint];

        // Move towards the waypoint
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Smoothly rotate towards the waypoint
        Vector3 direction = (target.position - transform.position).normalized;
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }

        // Check if we reached the waypoint
        if (Vector3.Distance(transform.position, target.position) < reachThreshold)
        {
            currentPoint++;

            // If we reached the end of the path
            if (currentPoint >= wayPointList.Count)
            {
                Instantiate(enemy, wayPointList[0].transform.position, transform.rotation);
                Destroy(gameObject); // Enemy vanishes (you could replace this with health reduction, etc.)
               
            }
        }
    }
}