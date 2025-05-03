// using UnityEngine;

// public class PlaneMovementWithGoal : MonoBehaviour
// {
//     public Transform goal;
//     public float baseSpeed = 1.0f;
//     public float accuracy = 0.01f;

//     void Start()
//     {
//         this.transform.LookAt(goal.position);
//     }

//     void Update()
//     {
//         // 1. Calcular dirección normalizada en espacio mundial
//         Vector3 direction = goal.position - transform.position;
        
//         // 2. Si está demasiado cerca, no mover
//         if (Vector3.Distance(transform.position, goal.position) <= accuracy) return;

//         // Move the object forward along its z axis 1 unit/second.
//         // 3. Rotar y mover
//         this.transform.LookAt(goal.position);
//         this.transform.Translate(
//             direction.normalized * baseSpeed * Time.deltaTime,
//             Space.World);
        
//         // Debug: línea roja muestra dirección mundial
//         Debug.DrawRay(this.transform.position, direction, Color.red);
//     }
// }