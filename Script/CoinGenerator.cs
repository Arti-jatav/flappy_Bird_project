
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public GameObject coinObject;
    public Transform CoinGenPoint;
    float Distence;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distence = Random.Range(0, 4);
        if(transform.position.x < CoinGenPoint.transform.position .x)
        {
            transform.position = new Vector3(transform.position.x + Random.Range(1, 5), Distence , transform.position.z);
            Instantiate(coinObject, transform.position, transform.rotation);
        }
    }
}
