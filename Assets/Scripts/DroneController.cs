using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    private Animator anim;

    Vector3 speed = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("TakeOff", true);
    }

    public void Move(float speedX, float speedZ)
    {
        speed.x = speedX;
        speed.y = speedZ;

        DroneMovement();
    }



    // Update is called once per frame
    void DroneMovement()
    {
        transform.localPosition += speed * Time.deltaTime; 
    }
}
