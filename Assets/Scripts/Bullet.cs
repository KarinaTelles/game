using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    public Player dono;
    // Start is called before the first frame update
    void Start()
    {
        direction = transform.right;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.CompareTag("Wall"))
        {
            foreach (var item in col.contacts)
            {
                direction = 2 * Vector3.Dot(direction, Vector3.Normalize(item.normal)) * Vector3.Normalize(item.normal) - direction;
                direction = direction * -1;
            }

        }
        if (col.gameObject.CompareTag("Player"))
        {
            var auxiliar = col.gameObject.GetComponent<Player>();
            if (auxiliar != dono) 
            {
                auxiliar.pontosDeVida-=10;
            }
        }

    }
    private void OnDestroy()
    {
        GameManeger.instancia.PassarTurno();
    }
}
