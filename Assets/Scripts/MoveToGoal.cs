using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);


    void Update()
    {
        // move goal
        this.transform.Translate(goal);

        // disminuir el paso de movimiento
        goal = goal * 0.5f;

        Debug.Log("Goal has moved, check new position");
    }
}
