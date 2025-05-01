using UnityEngine;

    public class PlaneMovementWithGoal : MonoBehaviour
    {
        public Transform goal;
        public float speed = 1.0f;

        void Update()
        {
            // Use the normalized direction vector
            this.transform.Translate(goal.normalized * speed * Time.deltaTime);
        }
    }