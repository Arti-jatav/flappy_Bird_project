
using UnityEngine;

public class PlateformGenerator : MonoBehaviour
{
    public GameObject Plateform;
    public Transform plateformGenPoint;
    private float width;
    void Start()
    {
        width = Plateform.GetComponent<BoxCollider2D>().size.x;
        
    }
    void Update()
    {
      if(transform.position.x < plateformGenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width, transform.position.y, transform.position.z);
            Instantiate(Plateform, transform.position, transform.rotation);
        }
       
    }
}
