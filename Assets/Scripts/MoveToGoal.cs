using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // move goal
        this.transform.Translate(goal);
        Debug.Log("Goal has moved, check new position");
    }
}
