using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllienBUllet : MonoBehaviour {


    private Rigidbody2D rigiBody;
    public float speed = 30;

    public Sprite ExploedSheepImage;


	// Use this for initialization
	void Start () {


        rigiBody = GetComponent<Rigidbody2D>();

        rigiBody.velocity = Vector2.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destory bullet when touch wall
        if (collision.tag == "Wall")
        {

            Destroy(gameObject);
        }

        if(collision.tag=="Space")
        {
            //Sound for destory spaceship
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.shipExplosiona);
            collision.GetComponent<SpriteRenderer>().sprite = ExploedSheepImage;

            //destroy alien's bullet
            Destroy(gameObject);

            //destroy ship
            DestroyObject(collision.gameObject,0.5f);
        }

        if(collision.tag=="Shield")
        {
            Destroy(gameObject);
            DestroyObject(collision.gameObject);
        }
    }



    void UpdateInVisible()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
