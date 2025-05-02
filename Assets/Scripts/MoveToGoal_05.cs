using UnityEngine;

public class PlaneMovementWithGoal : MonoBehaviour
{
    public Transform goal;
    public float baseSpeed = 1.0f;
    public float speedIncrement = 1.0f;
    private float _currentSpeed;

    public KeyCode boostKey = KeyCode.Space;
    void Start()
    {
        // asignar la velocidad actual como velocidad inicial.
        _currentSpeed = baseSpeed;
        // Primero giramos el personaje para que mire al objetivo
        this.transform.LookAt(goal.position);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentSpeed += speedIncrement;
        }
        // Calculamos la dirección hacia el objetivo
        Vector3 direction = goal.position - this.transform.position;
        
        // Normalizamos el vector dirección (magnitud = 1) y aplicamos velocidad y tiempo
        // Movemos al personaje en coordenadas globales (Space.World)
        this.transform.Translate(
            direction.normalized * _currentSpeed * Time.deltaTime, 
            Space.World
        );

        // mostrar la dirección
        Debug.DrawRay(this.transform.position,direction,Color.red);
    }
    public void ResetSpeed()
    {
        _currentSpeed = baseSpeed;
    }
}