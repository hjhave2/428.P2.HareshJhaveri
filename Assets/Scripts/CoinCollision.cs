using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Coin")
        {
            Destroy(collision.collider.gameObject);
            
        }
    }
}
