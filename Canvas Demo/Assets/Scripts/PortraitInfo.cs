using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://forum.unity.com/threads/mini-tutorial-on-changing-sprite-on-runtime.212619/

public class PortraitInfo : MonoBehaviour
{
private SpriteRenderer spriteRenderer;
public Sprite[] playerSprites;
 
 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = playerSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.GetHealth() > 75f){
// Debug.Log("At full!");
        spriteRenderer.sprite = playerSprites[0];
        }else if(GameManager.Instance.GetHealth() > 50f){

        spriteRenderer.sprite = playerSprites[1];
        }else{
          
        spriteRenderer.sprite = playerSprites[2];  
        }
    }
}
