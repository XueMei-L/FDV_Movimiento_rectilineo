using UnityEngine;

public class PlaneMovementWithGoal : MonoBehaviour
{
    public Vector3 goal = new Vector3(0,0,0);

    void Update()
    {

        // Use the normalized direction vector
        goal *= .5f;
    
        this.transform.Translate(goal.normalized);
    }
}