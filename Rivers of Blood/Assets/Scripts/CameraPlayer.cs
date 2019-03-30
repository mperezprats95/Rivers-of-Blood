using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour {

    public GameObject player;
    

    private Vector3 Poffset;
    

    void Start ()
    {
        Poffset = transform.position - player.transform.position;
        
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {

        transform.position = new Vector3(player.transform.position.x + Poffset.x, Poffset.y-2.94f,-3);



    }
}
