using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MoveOnKey : MonoBehaviour
{
    public GameObject Icon;
    public GameObject Right;
    public GameObject Left;
    public GameObject Normal;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.E))
        {
            Icon.transform.position = Vector3.MoveTowards(Icon.transform.position, Right.transform.position, speed);
        }
        if (Input.GetKey (KeyCode.Q))
        {
            Icon.transform.position = Vector3.MoveTowards(Icon.transform.position, Left.transform.position, speed);
        }
        if (Input.GetKey (KeyCode.W))
        {
            Icon.transform.position = Vector3.MoveTowards(Icon.transform.position, Normal.transform.position, speed);
        }
    }
}
