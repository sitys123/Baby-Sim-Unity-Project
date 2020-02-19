using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == 9) {
            if ( other.gameObject.tag == "Drink")
            {
                Debug.Log("Baby + Energy bar");
               
                Destroy(other.gameObject);
            }

            else if(other.gameObject.tag == "Food")
            {
                Debug.Log("Baby + Food bar");
                Destroy(other.gameObject);
            }
            
        }
           
    }
  
}
