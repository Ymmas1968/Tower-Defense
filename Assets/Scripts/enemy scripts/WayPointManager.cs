using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class WayPointManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private List<Transform> waypoints = new();
    
    public List<Transform> GetWayPoints()
    {
        return waypoints;
    }
}
