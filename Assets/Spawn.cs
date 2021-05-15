using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   
    public float maxTime = 1f;
     float timer;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject ob = Instantiate(pipe);
        ob.transform.position = transform.position + new Vector3(0, Random.Range(height, -height), 0);
    }

    // Update is called once per frame
    void Update()
    {
       /* if (timer > maxTime)
        {
            GameObject ob = Instantiate(pipe);
            ob.transform.position = transform.position + new Vector3(0,Random.Range(height, -height), 0);
            timer = 0;
        }
        timer += Time.deltaTime;*/
    }
}
