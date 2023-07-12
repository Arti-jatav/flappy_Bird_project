
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform targetposition;
    public Vector3 offset;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 newposition = targetposition.position + offset;
        newposition.y = 0;
        newposition.z = -1;
        transform.position = newposition;
    }
}
