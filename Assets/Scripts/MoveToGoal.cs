using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);

    void Start()
    {
        // disminuir el paso de movimiento
        goal = goal * 0.5f;
    }
    
    void Update()
    {
        // disminuir el paso de movimiento
        goal = goal * 0.5f;
        
        // move goal
        this.transform.Translate(goal);
        Debug.Log("Goal has moved, check new position");
    }
}
