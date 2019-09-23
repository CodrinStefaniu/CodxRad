using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float maxSpeed = 5f;
    float rotSpeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckUserInput();

    }

    void CheckUserInput()
    {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;

        //For rotation, not working now

        //z += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        //rot = Quaternion.Euler(0, 0, z);
        //transform.rotation = rot;

        //Move the ship
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        transform.position = pos;
    }
}
