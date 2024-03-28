using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBus : MonoBehaviour
{
    public enum EventType { PickupWeapon1, PickupWeapon2, PickupWeapon3, PickupWeapon4, PickupWeapon5, SwitchWeapon1, SwitchWeapon2,
      SwitchWeapon3, SwitchWeapon4, SwitchWeapon5, PickupHealth, TakeDamage, PickupArmor, PickupAmmo1,
       PickupAmmo2, PickupAmmo3, UseAmmo1,
       UseAmmo2, UseAmmo3, PickupKey};

    private static IDictionary<EventType, UnityEvent> _events = new Dictionary<EventType, UnityEvent>();

    public static void Publish(EventType eventType)
    {
        Debug.LogFormat("EventBus: Publish {0}", eventType);
        UnityEvent thisEvent;
        if (_events.TryGetValue(eventType, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }

    public static void Subscribe(EventType eventType, UnityAction listener)
    {
        UnityEvent thisEvent;
        if(_events.TryGetValue(eventType, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            _events.Add(eventType, thisEvent);
        }
    }

    public static void Unsubscribe(EventType eventType, UnityAction listener)
    {
        UnityEvent thisEvent;
        if (_events.TryGetValue(eventType, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    
}
