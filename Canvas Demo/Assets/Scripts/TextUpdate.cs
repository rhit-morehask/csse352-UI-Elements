using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    enum Field { Ammo, Health, Armor};
    [SerializeField] WeaponKeyManager weaponKeyManager;
    [SerializeField] Field field = Field.Ammo;
    TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        weaponKeyManager = FindObjectOfType<WeaponKeyManager>();
        text = GetComponent<TMP_Text>();
        SetText();
        switch(field){
            case Field.Ammo:
        EventBus.Subscribe(EventBus.EventType.PickupAmmo1, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupAmmo2, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupAmmo3, SetText);
        EventBus.Subscribe(EventBus.EventType.UseAmmo1, SetText);
        EventBus.Subscribe(EventBus.EventType.UseAmmo2, SetText);
        EventBus.Subscribe(EventBus.EventType.UseAmmo3, SetText);

        EventBus.Subscribe(EventBus.EventType.PickupWeapon1, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon2, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon3, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon4, SetText);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon5, SetText);

        EventBus.Subscribe(EventBus.EventType.SwitchWeapon1, SetText);
        EventBus.Subscribe(EventBus.EventType.SwitchWeapon2, SetText);
        EventBus.Subscribe(EventBus.EventType.SwitchWeapon3, SetText);
        EventBus.Subscribe(EventBus.EventType.SwitchWeapon4, SetText);
        EventBus.Subscribe(EventBus.EventType.SwitchWeapon5, SetText);
        break;
        case Field.Health:
        EventBus.Subscribe(EventBus.EventType.PickupHealth, SetText);
        EventBus.Subscribe(EventBus.EventType.TakeDamage, SetText);
        break;
        case Field.Armor:
        EventBus.Subscribe(EventBus.EventType.PickupArmor, SetText);
        EventBus.Subscribe(EventBus.EventType.TakeDamage, SetText);
        break;
        // EventBus.Subscribe(EventBus.EventType.PlayerDie, SetText);
        }

    }
    //when taking damage/not, check message type.
    //update accordingly
    //see char portrait sprites

    // Update is called once per frame
    void Update()
    {
        //SetText();

    }

    void SetText()
    {
        int currWepID = GameManager.Instance.GetCurrentWeapon();
        int ammo = weaponKeyManager.GetAmmoCount(currWepID);
        switch(field){
            case Field.Ammo:
            text.text = ammo.ToString();
            break;
            case Field.Health:
            text.text = string.Format("{0:F1}",GameManager.Instance.GetHealth()) + "%";
            break;
            case Field.Armor:
            text.text = string.Format("{0:F1}",GameManager.Instance.GetArmor()) + "%";
            break;
        }
        // if (field == Field.Score)
        // {
        //     text.text = "Score: " + GameManager.Instance.Points.ToString();
        // }
        // else
        // {
        //     text.text = "Lives: " + GameManager.Instance.Lives.ToString();

        // }
    }
}
