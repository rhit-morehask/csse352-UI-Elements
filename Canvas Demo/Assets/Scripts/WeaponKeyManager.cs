using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponKeyManager : MonoBehaviour
{
    [SerializeField] GameObject weapon1;
    [SerializeField] GameObject weapon2;
    [SerializeField] GameObject weapon3;
    [SerializeField] GameObject weapon4;
    [SerializeField] GameObject weapon5;
    //Q W E R T 12345 Enter
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe(EventBus.EventType.PickupWeapon1, AddWeapon1);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon2, AddWeapon2);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon3, AddWeapon3);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon4, AddWeapon4);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon5, AddWeapon5);

    }

    // Update is called once per frame
    public void AddWeapon1()
    {
        weapon1.GetComponent<WeaponKeyInfo>().ObtainWeaponText();
    }
    public void AddWeapon2()
    {
        weapon2.GetComponent<WeaponKeyInfo>().ObtainWeaponText();
    }
    public void AddWeapon3()
    {
        weapon3.GetComponent<WeaponKeyInfo>().ObtainWeaponText();
    }
    public void AddWeapon4()
    {
        weapon4.GetComponent<WeaponKeyInfo>().ObtainWeaponText();
    }
    public void AddWeapon5()
    {
        weapon5.GetComponent<WeaponKeyInfo>().ObtainWeaponText();
    }

    public bool getStatusOfWeapon(int id){
    switch(id){
        case 1:
            return weapon1.GetComponent<WeaponKeyInfo>().GetStatus();
        case 2:
            return weapon2.GetComponent<WeaponKeyInfo>().GetStatus();
        case 3:
            return weapon3.GetComponent<WeaponKeyInfo>().GetStatus();
        case 4:
            return weapon4.GetComponent<WeaponKeyInfo>().GetStatus();
        case 5:
            return weapon5.GetComponent<WeaponKeyInfo>().GetStatus();
        default:
            return false;
    }
}
public int GetAmmoCount(int id){
    switch(id){
        case 1:
            return weapon1.GetComponent<WeaponKeyInfo>().GetAmmo();
        case 2:
            return weapon2.GetComponent<WeaponKeyInfo>().GetAmmo();
        case 3:
            return weapon3.GetComponent<WeaponKeyInfo>().GetAmmo();
        case 4:
            return weapon4.GetComponent<WeaponKeyInfo>().GetAmmo();
        case 5:
            return weapon5.GetComponent<WeaponKeyInfo>().GetAmmo();
        default:
            return 100;
    }
}

public void SetAmmoCount(int id){
    switch(id){
        case 1:
            weapon1.GetComponent<WeaponKeyInfo>().SetAmmo();
            weapon2.GetComponent<WeaponKeyInfo>().SetAmmo();
            break;
        case 2:
            weapon3.GetComponent<WeaponKeyInfo>().SetAmmo();
            weapon4.GetComponent<WeaponKeyInfo>().SetAmmo();
            break;
        case 3:
            weapon5.GetComponent<WeaponKeyInfo>().SetAmmo();
            break;
    }
}

public void UseAmmoCount(int id){
    switch(id){
        case 1:
            weapon1.GetComponent<WeaponKeyInfo>().UseAmmo();
            weapon2.GetComponent<WeaponKeyInfo>().UseAmmo();
            break;
        case 2:
            weapon3.GetComponent<WeaponKeyInfo>().UseAmmo();
            weapon4.GetComponent<WeaponKeyInfo>().UseAmmo();
            break;
        case 3:
            weapon5.GetComponent<WeaponKeyInfo>().UseAmmo();
            break;
    }
}
        // life1.SetActive(false);
        // life2.SetActive(false);
        // life3.SetActive(false);
        

        // if (GameManager.Instance.Lives >= 1)
        // {
        //     life1.SetActive(true);
        // }
        // if(GameManager.Instance.Lives >= 2)
        // {
        //     life2.SetActive(true);

        // }
        // if (GameManager.Instance.Lives >= 3)
        // {
        //     life3.SetActive(true);
        // }
}
