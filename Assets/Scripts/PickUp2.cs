using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp2 : MonoBehaviour
{
    public Transform item;
    public float range = 5f;

    new Camera camera;

    bool cooldown;

    private void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && cooldown == false) {
            cooldown = true;

            if (item.childCount == 0 ) {
                
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Debug.Log("if :"+item.childCount);

                if (Physics.Raycast(ray, out hit, range))
                {
                    GetComponent<BoxCollider>().enabled = false;
                    GetComponent<Rigidbody>().useGravity = false;
                    this.transform.position = item.position;
                    this.transform.parent = GameObject.Find("Hand").transform;
                }
            }
            else {
                Debug.Log("else :"+item.childCount);
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<BoxCollider>().enabled = true;
            }

            Invoke("resetCoolDown",2f);
        }
    }

    void resetCoolDown()
    {
        cooldown = false;
    }
 
}
