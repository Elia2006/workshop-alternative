using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.03f, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.03f, 0, 0);
        }

        if(transform.position.x > 5)
        {
            transform.position = new Vector3(5, 0, 0);
        }
        if(transform.position.x < -5)
        {
            transform.position = new Vector3(-5, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Debug.Log("Game Over");
    }
}
