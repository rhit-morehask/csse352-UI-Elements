using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponKeyInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isActive = false;
    public int id = 1;
    public int ammo = 100;
        TMP_Text text;
    void Start()
    {
        text = GetComponentInChildren<TMP_Text>();
        text.color = Color.gray;
        
    }

    // Update is called once per frame
    public void ObtainWeaponText(){
        isActive = true;
        //Debug.Log("am alive");
            text.color = Color.yellow;
    }
    public void DropWeaponText()
    {
        isActive = false;
            text.color = Color.gray;
    }
    public bool GetStatus(){
        return isActive;
    }
    public int GetAmmo(){
        return ammo;
    }
    public void SetAmmo(){
        if(ammo < 200){
        if(Random.Range(0f, 1f) > 0.5){
            ammo += 5;
        }else{
            ammo += 10;
        }
        }else{
            ammo = 200;
        }
    }
    public void UseAmmo(){
        if(ammo > 0){
        if(Random.Range(0f, 1f) > 0.5){
            ammo -= 5;
        }else{
            ammo -= 10;
        }
        }else{
            ammo = 0;
        }
    }
}
