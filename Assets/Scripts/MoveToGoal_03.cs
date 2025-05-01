// using UnityEngine;

// public class PlaneMovementWithGoal : MonoBehaviour
// {
//     public Transform goal;
//     public float speed = 1.0f;
//     void Start()
//     {
//         // Primero giramos el personaje para que mire al objetivo
//         this.transform.LookAt(goal.position);
//     }

//     void Update()
//     {
//         // Calculamos la dirección hacia el objetivo
//         Vector3 direction = goal.position - this.transform.position;
        
//         // Normalizamos el vector dirección (magnitud = 1) y aplicamos velocidad y tiempo
//         // Movemos al personaje en coordenadas globales (Space.World)
//         this.transform.Translate(
//             direction.normalized * speed * Time.deltaTime, 
//             Space.World
//         );

//     }
// }