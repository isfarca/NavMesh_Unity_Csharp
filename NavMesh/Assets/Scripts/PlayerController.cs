using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour 
{
    // Declare variables.
    [SerializeField] private Camera _camera;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    /// <summary>
    /// Setting the destination of enemy.
    /// </summary>
    private void Update()
    {
        // When you click a position in a map, then set the destination of enemy.
        if (!Input.GetMouseButtonDown(0)) 
            return;
       
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            _navMeshAgent.SetDestination(hit.point);
    }
}