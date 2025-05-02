using UnityEngine;

public class PlaneMovementWithGoal : MonoBehaviour
{
    public Transform goal;
    public float baseSpeed = 1.0f;

    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    void Update()
    {
        this.transform.LookAt(goal.position);
        // Mirar hacia el objeto destino

        // 1. Calcular dirección normalizada en espacio mundial
        Vector3 direction = goal.position - transform.position;

        // Move the object forward along its z axis 1 unit/second.
        // Movimiento en forward local (sin Space.World)
        this.transform.Translate(
            direction.normalized * baseSpeed * Time.deltaTime,
            Space.World);
        
        // Debug: línea roja muestra dirección mundial
        Debug.DrawRay(this.transform.position, direction, Color.red);
    }
}