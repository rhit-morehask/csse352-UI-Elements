using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    WeaponKeyManager weaponKeyManager;
    void Start()
    {
        weaponKeyManager = FindObjectOfType<WeaponKeyManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //toggle weapon code
        if(Input.GetKeyDown(KeyCode.Q)){
            bool weapon = weaponKeyManager.getStatusOfWeapon(1);
            EventBus.Publish(EventBus.EventType.PickupWeapon1);
            if(weapon){
                
            EventBus.Publish(EventBus.EventType.PickupAmmo1);
            }
        }
        if(Input.GetKeyDown(KeyCode.W)){
            bool weapon = weaponKeyManager.getStatusOfWeapon(2);
            EventBus.Publish(EventBus.EventType.PickupWeapon2);
            if(weapon){    
            EventBus.Publish(EventBus.EventType.PickupAmmo1);
            }
        }
        if(Input.GetKeyDown(KeyCode.E)){
            bool weapon = weaponKeyManager.getStatusOfWeapon(3);
            if(weapon){
            EventBus.Publish(EventBus.EventType.PickupAmmo2);
            }
            EventBus.Publish(EventBus.EventType.PickupWeapon3);
        }
        if(Input.GetKeyDown(KeyCode.R)){
            bool weapon = weaponKeyManager.getStatusOfWeapon(4);
            if(weapon){
            EventBus.Publish(EventBus.EventType.PickupAmmo2);
            }
            EventBus.Publish(EventBus.EventType.PickupWeapon4);
        }
        if(Input.GetKeyDown(KeyCode.T)){
            bool weapon = weaponKeyManager.getStatusOfWeapon(5);
            if(weapon){
            EventBus.Publish(EventBus.EventType.PickupAmmo3);
            }
            EventBus.Publish(EventBus.EventType.PickupWeapon5);
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
           bool weapon = weaponKeyManager.getStatusOfWeapon(1);
            if(weapon && GameManager.Instance.GetCurrentWeapon() != 1){
            EventBus.Publish(EventBus.EventType.SwitchWeapon1);
             GameManager.Instance.SetCurrentWeapon(1);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
           bool weapon = weaponKeyManager.getStatusOfWeapon(2);
        
            if(weapon &&  GameManager.Instance.GetCurrentWeapon() != 2){
            EventBus.Publish(EventBus.EventType.SwitchWeapon2);
             GameManager.Instance.SetCurrentWeapon(2);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
           bool weapon = weaponKeyManager.getStatusOfWeapon(3);
            if(weapon &&  GameManager.Instance.GetCurrentWeapon() != 3){
            EventBus.Publish(EventBus.EventType.SwitchWeapon3);
             GameManager.Instance.SetCurrentWeapon(3);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
           bool weapon = weaponKeyManager.getStatusOfWeapon(4);
        
            if(weapon &&  GameManager.Instance.GetCurrentWeapon() != 4){
            EventBus.Publish(EventBus.EventType.SwitchWeapon4);
             GameManager.Instance.SetCurrentWeapon(4);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
           bool weapon = weaponKeyManager.getStatusOfWeapon(5);
        
            if(weapon &&  GameManager.Instance.GetCurrentWeapon() != 5){
            EventBus.Publish(EventBus.EventType.SwitchWeapon5);
             GameManager.Instance.SetCurrentWeapon(5);
            }
        }

        if(Input.GetKeyDown(KeyCode.A)){
EventBus.Publish(EventBus.EventType.PickupHealth);
GameManager.Instance.SetHealth(15f);
        }
        if(Input.GetKeyDown(KeyCode.S)){
EventBus.Publish(EventBus.EventType.TakeDamage);
GameManager.Instance.SetHealth(-15f);
GameManager.Instance.SetArmor(-15f);
        }
        if(Input.GetKeyDown(KeyCode.D)){
EventBus.Publish(EventBus.EventType.PickupArmor);
GameManager.Instance.SetArmor(15f);
        }
        if(Input.GetKeyDown(KeyCode.Z)){
EventBus.Publish(EventBus.EventType.PickupAmmo1);
weaponKeyManager.SetAmmoCount(1);
        }
        if(Input.GetKeyDown(KeyCode.X)){
EventBus.Publish(EventBus.EventType.PickupAmmo2);
weaponKeyManager.SetAmmoCount(2);
        }
        if(Input.GetKeyDown(KeyCode.C)){
EventBus.Publish(EventBus.EventType.PickupAmmo3);
weaponKeyManager.SetAmmoCount(3);
        }
        
        if(Input.GetKeyDown(KeyCode.V)){
EventBus.Publish(EventBus.EventType.UseAmmo1);
weaponKeyManager.UseAmmoCount(1);
        }
        if(Input.GetKeyDown(KeyCode.B)){
EventBus.Publish(EventBus.EventType.UseAmmo2);
weaponKeyManager.UseAmmoCount(2);
        }
        if(Input.GetKeyDown(KeyCode.N)){
EventBus.Publish(EventBus.EventType.UseAmmo3);
weaponKeyManager.UseAmmoCount(3);
        }
        if(Input.GetKeyDown(KeyCode.K)){
EventBus.Publish(EventBus.EventType.PickupKey);
        }
    }

}
