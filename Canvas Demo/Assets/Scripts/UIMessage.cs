using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMessage : MonoBehaviour
{
    // Start is called before the first frame update
    string lastMessage = "PICKED UP A HEALTH BONUS.";
    TMP_Text text;
    void Start()
    {
        text = GetComponent<TMP_Text>();
        text.text = "";
        EventBus.Subscribe(EventBus.EventType.PickupWeapon1, PickupW1);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon2, PickupW2);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon3, PickupW3);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon4, PickupW4);
        EventBus.Subscribe(EventBus.EventType.PickupWeapon5, PickupW5);
        EventBus.Subscribe(EventBus.EventType.PickupHealth, PickupH);
        EventBus.Subscribe(EventBus.EventType.PickupArmor, PickupA);
        EventBus.Subscribe(EventBus.EventType.PickupAmmo1, PickupAmmo);
        EventBus.Subscribe(EventBus.EventType.PickupAmmo2, PickupAmmo);
        EventBus.Subscribe(EventBus.EventType.PickupAmmo3, PickupAmmo);
        EventBus.Subscribe(EventBus.EventType.PickupKey, PickupKey);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            DisplayMessage();
        }
        
    }
    void DisplayMessage(){
            text.text = lastMessage;
            StartCoroutine(DisplayMessageCoroutine());
    }
    private IEnumerator DisplayMessageCoroutine()
    {
        float messageTimer = 10f;
        while (messageTimer > 0)
        {
            messageTimer -= Time.deltaTime;
            yield return null;
        }
        text.text = "";
    }
    public void PickupW1(){
        lastMessage = "Picked up chaingun.";
        DisplayMessage();
    }
    public void PickupW2(){
        lastMessage = "Picked up pistol.";
        DisplayMessage();
    }
    public void PickupW3(){        
        lastMessage = "Picked up shotgun.";
        DisplayMessage();
    }
    public void PickupW4(){        
        lastMessage = "Picked up super shotgun.";
        DisplayMessage();
    }
    public void PickupW5(){        
        lastMessage = "Picked up BFG9000.";
        DisplayMessage();
    }
    public void PickupH(){        
        lastMessage = "Picked up a health bonus.";
        DisplayMessage();
    }
    public void PickupA(){        
        lastMessage = "Picked up an armor bonus.";
        DisplayMessage();
    }
    public void PickupAmmo(){        
        lastMessage = "Picked up ammo.";
        DisplayMessage();
    }
    public void PickupKey(){        
        lastMessage = "Picked up key.";
        DisplayMessage();
    }

}
