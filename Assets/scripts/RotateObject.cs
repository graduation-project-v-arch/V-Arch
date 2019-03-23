using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject c;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /*make any object and put this script on it */
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {

            c.transform.Rotate(Vector3.right * speed * Time.deltaTime * 10);
            Debug.Log("X Aises");
        }
        if (Input.GetKey(KeyCode.C))
        {
            c.transform.Rotate(-Vector3.right * speed * Time.deltaTime * 10);
            Debug.Log("- X Aises");
        }
        if (Input.GetKey(KeyCode.Z))
        {
            c.transform.Rotate(Vector3.forward * speed * Time.deltaTime * 10);
            Debug.Log("Z Aises");
        }
        if (Input.GetKey(KeyCode.A))
        {
            c.transform.Rotate(-Vector3.forward * speed * Time.deltaTime * 10);
            Debug.Log("- Z Aises");
        }
        if (Input.GetKey(KeyCode.Y))
        {
            c.transform.Rotate(Vector3.up * speed * Time.deltaTime * 10);
            Debug.Log("Y Aises");
        }
        if (Input.GetKey(KeyCode.D))
        {
            c.transform.Rotate(-Vector3.up * speed * Time.deltaTime * 10);
            Debug.Log("- Y Aises");
        }


    }
}
