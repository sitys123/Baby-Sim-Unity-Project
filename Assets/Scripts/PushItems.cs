using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PushItems : MonoBehaviour
{
    public float pushPower = 2f;
    public float weight = 6f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        Vector3 force = new Vector3(0,0,0);

        if (hit.gameObject.layer == 9) {
            Debug.Log("hit");
            if(hit.moveDirection.y < -0.3)
            {
                force = new Vector3(0f,-0.5f,0f) * 20f * weight;
            }
            else
            {
                force = hit.controller.velocity * pushPower;
            }

            body.AddForceAtPosition(force, hit.point);
        }

    }
}*/

public class PushItems : MonoBehaviour
{

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body != null && !body.isKinematic)
        {
            Debug.Log("velocity =" + body.velocity);
            body.velocity += hit.controller.velocity;
        }
    }
}
