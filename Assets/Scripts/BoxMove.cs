using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float speed = 0.005f;
    public float speedBoost = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A)) Move(-speed, 0, speed);
            else if (Input.GetKey(KeyCode.D)) Move(speed, 0, speed);
            else Move(0, 0, speed);
        }
    }

    void Move(float x, float y, float z)
    {
        if (AreRunning()) transform.position += new Vector3(x * speedBoost, y * speedBoost, z * speedBoost);
        else transform.position += new Vector3(x, y, z);
    }

    bool AreRunning()
    {
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            return true;
        }
        else return false;
    }
}
