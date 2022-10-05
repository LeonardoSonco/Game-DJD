using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] pos;
    public GameObject enemy;
    float tempo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        if (tempo >= 1.5f)
        {
            int x = Random.Range(0, 4);
            //Instantiate(enemy, pos[x].transform.position, Quaternion.identity);
            tempo = 0;
        }
    }
}
