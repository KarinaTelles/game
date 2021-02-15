using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*public bool player;*/
    public int player;    
    [SerializeField] int turn;
    [SerializeField] float speed;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime * Input.GetAxisRaw("Vertical"), 0);
        }
        if (Input.GetButton("Horizontal"))
        {
            transform.eulerAngles += new Vector3(0, 0, turn * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gun.position, Quaternion.identity);
        }
            
    }
}
