using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*public bool player;*/
    public int player;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0, 0, speed * Time.deltaTime);//adiciona 1 graus
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0, 0, -speed * Time.deltaTime);//adiciona 1 graus
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1 *Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
        }
    }
}
