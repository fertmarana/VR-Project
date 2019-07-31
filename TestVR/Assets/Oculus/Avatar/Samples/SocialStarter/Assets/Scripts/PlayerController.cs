using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public int speed = 0;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // get input data from keyboard or controller
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        Vector2  move = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);



        // update player position based on input
        Vector3 position = transform.position;
        position.x += move.x * speed * Time.deltaTime;
        position.z += move.y * speed * Time.deltaTime;
        transform.position = position;
    }
}