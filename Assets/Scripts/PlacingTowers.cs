using UnityEngine;

public class DragTower : MonoBehaviour
{
    private GameObject currentTower;   // The tower we're dragging
    public GameObject towerPrefab;     // The prefab you want to place
    public LayerMask groundMask;
    [SerializeField] private Camera camera;// The layer(s) where the tower can be placed

    void Update()
    {
        // If we have a tower being dragged, follow mouse
        if (currentTower != null)
        {
            MoveTowerToMouse();

            // Place tower on left mouse click
            if (Input.GetMouseButtonDown(0))
            {
                currentTower = null; // stop dragging
            }
            if (Input.GetMouseButtonDown(1))
            {
                StartDraggingTower();   
            }
        }
       
    }

    public void StartDraggingTower()
    {
        currentTower = Instantiate(towerPrefab);
    }

    void MoveTowerToMouse()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, groundMask))
        {
            Vector3 newPos = hit.point;
            newPos.y = 0; // Keep tower aligned with ground
            currentTower.transform.position = newPos;
        }
    }
}