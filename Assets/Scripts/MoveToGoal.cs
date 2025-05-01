using UnityEngine;

    public class PlaneMovementWithGoal : MonoBehaviour
    {
        public Vector3 goal = new Vector3(0,0,0);
        public float speed = 0.1f;

        void Update()
        {
            // Use the normalized direction vector
            this.transform.Translate(goal.normalized*speed);
        }
    }