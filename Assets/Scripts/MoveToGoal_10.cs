using UnityEngine;
using UnityStandardAssets.Utility;

public class TargetMovement : MonoBehaviour
{
    public float targetSpeed = 2.0f;
    public float accuracy = 0.01f;
    private Transform  target;

    void Start()
    {
        // get the next point on the circuit to which you should go
        target = GetComponent<WaypointProgressTracker>().target;
    }

    void Update()
    {
        if (target == null) return;

        // Rotación suave hacia el objetivo
        Vector3 direction = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            targetSpeed * Time.deltaTime
        );

        // Movimiento hacia adelante (local)
        transform.Translate(Vector3.forward * targetSpeed * Time.deltaTime, Space.Self);
        
        Debug.DrawRay(this.transform.position, direction, Color.red);
    }

}