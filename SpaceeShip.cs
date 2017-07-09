using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceeShip : MonoBehaviour {

	 public float Speed = 30;

    public GameObject theBullet;
    private void FixedUpdate()
    {
        float horzMove = Input.GetAxisRaw("Horizontal"); //Allows us use arrows keys
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove, 0) * Speed;

    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //shoot bullets when  space key is pressing

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet, transform.position, Quaternion.identity);

            SoundManager.Instance.PlayOneShot(SoundManager.Instance.bulletFire);
        }

    }
}


