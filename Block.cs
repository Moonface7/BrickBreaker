using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Block : MonoBehaviour
{
    public static int totalBlockCount;
    public Sprite[] blockSprite;
    private int maxHitScore;
    private int hitScore;
    private Score ScoreScript;
    public AudioClip destroySound, hitSound;
    public GameObject breakEffect;
    public string nextLevel;

    void Start()
    {
        maxHitScore = blockSprite.Length + 1; 
        totalBlockCount++;
        ScoreScript = GameObject.FindAnyObjectByType<Score>().GetComponent<Score>();  //store the score variable
    }

    // when the ball hits the bricks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("ball")) //making sure "the ball" hits
        {
            ScoreScript.ScoreIncrease();
            hitScore++;
            
            if(hitScore >= maxHitScore)
            {
                totalBlockCount--;
                
                if (totalBlockCount <= 0)
                {                  
                    PlayerPrefs.SetInt(nextLevel, 1);
                    GameObject.FindObjectOfType<GameControl>().GetComponent<GameControl>().nextScene(); //When the bricks are finished, move on to the new scene.
                }
                Vector3 pos = collision.contacts[0].point; // first point of impact
                GameObject go = Instantiate(breakEffect, pos, Quaternion.identity) as GameObject;
                Color blockColor = GetComponent<SpriteRenderer>().color; //take the color of the brick
                go.GetComponent<ParticleSystemRenderer>().material.color = blockColor; //making the color of the pieces the same as the brick 
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(destroySound,transform.position);
                Destroy(this.gameObject);

            }
            else
            {
                AudioSource.PlayClipAtPoint(hitSound, transform.position);
                GetComponent<SpriteRenderer>().sprite = blockSprite[hitScore - 1];
            }
        }
    }
}
