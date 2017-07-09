using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyBullet : MonoBehaviour {


    public float Speed = 30;
    private Rigidbody2D rigiBody;

    public Sprite ExplodedAlienImage;
	// Use this for initialization
	void Start () {

        rigiBody = GetComponent<Rigidbody2D>();

        rigiBody.velocity = Vector2.up * Speed;

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Destory bullet when touch wall
if(collision.tag=="Wall")
        {

            Destroy(gameObject);
        }

if(collision.tag=="Shield")
        {
            Destroy(gameObject);
            DestroyObject(collision.gameObject);
        }


//Destory alien when bullet touch it  and evoke  alined dead image  as well as sound 
if(collision.tag=="Alien")
        {
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.alienDies);

            IncreaseScore();

            //evoke Image eplodeAliien and parenting it to get Component Sprite
            collision.GetComponent<SpriteRenderer>().sprite=ExplodedAlienImage;


            //destroy bullet
            Destroy(gameObject);

            //destory alien
            DestroyObject(collision.gameObject, 0.5f);

             
        }
    }

    void IncreaseScore()
    {
        var TextScore = GameObject.Find("Score").GetComponent<Text>();

        int score = int.Parse(TextScore.text);

        score += 10;

        TextScore.text=score.ToString();
    }

    private void OnBecameInVisible()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
