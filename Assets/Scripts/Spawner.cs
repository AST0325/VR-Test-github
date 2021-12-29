using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] blocks;
    public Transform[] points;
    public float beat;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            GameObject block = Instantiate(blocks[Random.Range(0, 2)],
                points[Random.Range(0, 11)]);
            block.transform.localPosition = Vector3.zero;
            block.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}
