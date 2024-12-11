using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningEnemy : MonoBehaviour
{
    public GameObject enemy;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < Time.time)
        {
            timer = Time.time + 1;
            Instantiate(enemy, new Vector3(Random.Range(-5, 5), 0, 30), Quaternion.identity);
        }
    }
}
