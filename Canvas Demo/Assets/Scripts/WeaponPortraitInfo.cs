using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPortraitInfo : MonoBehaviour
{private SpriteRenderer spriteRenderer;
public Sprite[] weaponSprites;
 
 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = weaponSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        switch(GameManager.Instance.GetCurrentWeapon()){
            case 1:
            Debug.Log("rendering weapon");
                spriteRenderer.sprite = weaponSprites[0];
                break;
            case 2:
            spriteRenderer.sprite = weaponSprites[1];
                break;
            case 3:
            spriteRenderer.sprite = weaponSprites[2];
                break;
            case 4:
            spriteRenderer.sprite = weaponSprites[3];
                break;
            case 5:
            spriteRenderer.sprite = weaponSprites[4];
                break;

        }
        }
    

}
