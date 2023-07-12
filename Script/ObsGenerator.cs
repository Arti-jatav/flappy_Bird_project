
using UnityEngine;

public class ObsGenerator : MonoBehaviour
{
    public Transform GenPoint;
    public GameObject Obstacle;
    float Diffrance;
    public float MinDiff, maxDiff;
    void Start()
    {
        
    }

   
    void Update()
    {
        Diffrance = Random.Range(MinDiff, maxDiff);
       if(transform.position.x < GenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + Diffrance, Random.Range(5,11) , transform.position.z);
            Instantiate(Obstacle, transform.position, transform.rotation);
        }
    }
}
