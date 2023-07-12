
using UnityEngine;

public class DistroyerScript : MonoBehaviour
{
    GameObject Distroyerobj;
    void Start()
    {
        Distroyerobj = GameObject.Find("Distroyer");  
    }
    void Update()
    {
       if(transform.position.x < Distroyerobj.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
