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

    [SerializeField] private HealthManager healthManager;

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

            // If we reached the last waypoint
            if (currentPoint >= wayPointList.Count)
            {
                HealthManager.Instance.TakeDamage(1);
                Destroy(gameObject); // Let the spawner handle new enemies
            }
            if (currentPoint >= wayPointList.Count)
            {
                HealthManager.Instance.TakeDamage(1);
                Destroy(gameObject); // Let the spawner handle new enemies
            }


        }
    }
}