using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject gameObj;
    private void OnTriggerEnter(Collider other)
    {
        
            Destroy(gameObj);
        




    }


}
