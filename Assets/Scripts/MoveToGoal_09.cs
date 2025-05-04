using UnityEngine;
using System.Collections.Generic;
using System.Linq; // Necesario para OrderBy

public class WaypointFollower : MonoBehaviour
{
    // la velocidad del personaje
    public float baseSpeed = 2.0f;
    // la magnitud entre el personaje y waypoint
    public float accuracy = 0.01f;

    // crear una lista para guardar todos los waypoints
    private List<Transform> waypoints = new List<Transform>();
    // para mostrar el waypoint actual
    private int currentWaypointIndex = 0;

    // inicialmente
    void Start()
    {
        // 1. Buscar todos los objetos con etiqueta"Waypoint" 
        // 2. Ordenar waypoints por nombre y crear la lista.
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint")
                       .OrderBy(wp => wp.name)  // Orden alfabético
                       .Select(wp => wp.transform)  // Convertir a Transform
                       .ToList();  // Crear lista

        // 3. Mostrar información en consola para comprobar que waypoints encontrados.
        Debug.Log($"=== WAYPOINTS ENCONTRADOS ({waypoints.Count}) ===");
        for (int i = 0; i < waypoints.Count; i++)
        {
            Debug.Log($"Waypoint {i}: {waypoints[i].name} (Posición: {waypoints[i].position})");
        }
    }

    void Update()
    {
        // 4. Comprobar que la lista no es nulo
        if (waypoints.Count == 0) return;

        // 5. Calcular dirección entre el waypoint y el personaje
        Transform currentWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = currentWaypoint.position - transform.position;

        // 6. Rotación suave hacia el waypoint
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            baseSpeed * Time.deltaTime
        );

        // 7. Movimiento hacia waypoint actual
        this.transform.Translate(
            direction.normalized * baseSpeed * Time.deltaTime,
            Space.World);

        // Mostrar la line de waypoint al llegar
        // Debug.DrawRay(transform.position, direction, Color.red);

        // 8.Cambiar al siguiente waypoint al llegar
        if (Vector3.Distance(transform.position, currentWaypoint.position) <= accuracy)
        {
            // restaurar color del waypoint anterior
            if (currentWaypointIndex < waypoints.Count)
            {
                waypoints[currentWaypointIndex].GetComponent<Renderer>().material.color = Color.yellow;
            }
            // para que cuando llegue al final, reinicia el ciclo.
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
            
            // Cambiar color del nuevo waypoint actual
            waypoints[currentWaypointIndex].GetComponent<Renderer>().material.color = Color.green;
        
            Debug.Log($"<color=green>Siguiente waypoint: {waypoints[currentWaypointIndex].name}</color>");
            
        }
    }
}