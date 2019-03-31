using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobico : MonoBehaviour
{
    public float time;
    public GameObject lobico;
    public bool changed = false;
    //public float time2 = Time.deltaTime;
    // Start is called before the first frame update
    void Start()
    {
       time = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if (time == 100  && changed == false)
        {
            lobico.transform.localScale = new Vector3(lobico.transform.localScale.x *-1,lobico.transform.localScale.y);
            changed = true;
            time = 0;
        }
        else
        if(time == 100 && changed == true)
        {
            lobico.transform.localScale = new Vector3(lobico.transform.localScale.x*-1, lobico.transform.localScale.y);
            changed = false;
            time = 0;
        }
        /*else
{
            time += Time.deltaTime;
        }*/
    }
}
