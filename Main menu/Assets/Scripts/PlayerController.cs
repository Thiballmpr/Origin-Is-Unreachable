using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    public float vitesse;

    private void Start()
    {
        //Network.Instantiate(pl, new Vector3(-98, 130, -4300));
    }

    void Update ()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 1.5f * vitesse;
        var z = Input.GetAxis("Vertical") *  Time.deltaTime * vitesse;

        transform.Translate(0, 0, z);
        transform.Rotate(0,x,0);
	}
}
