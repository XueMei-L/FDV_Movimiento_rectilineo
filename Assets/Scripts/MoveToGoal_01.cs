// using UnityEngine;

// public class PlaneMovementWithGoal : MonoBehaviour
// {
//     public Vector3 goal = new Vector3(3,0,0);
//     public Vector3 flygoal = new Vector3(5,3,0);
//     public Vector3 flyInSkygoal = new Vector3(1, 0, 0);
    
//     public float speed = 0.5f;
//     public float flySpeed = 0.3f;

//     private float timer = 0f;

//     void Update()
//     {
//         // to count timer
//         timer += Time.deltaTime;

//         goal = goal * 0.5f;
//         flygoal = flygoal * 0.5f;
//         flyInSkygoal = flyInSkygoal * 0.5f;

//         if(timer < 2f)
//         {
//             this.transform.Translate(goal * speed * Time.deltaTime);  // * Time.deltaTime is for the speed
//         } else if(timer > 2f && timer < 4f) {
//             this.transform.Translate(flygoal * flySpeed * Time.deltaTime);
//         } else {
//             this.transform.Translate(flyInSkygoal * flySpeed * Time.deltaTime);
//         }
//     }
// }