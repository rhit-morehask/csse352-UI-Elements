using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] int currWeaponID = 1;
    [SerializeField] float health = 100f;
    [SerializeField] float armor = 100f;


public void SetCurrentWeapon(int i){
    currWeaponID = i;
}
public int GetCurrentWeapon(){
    return currWeaponID;
}

public float GetHealth(){
    return health;
}

public float GetArmor(){
    return armor;
}

public void SetHealth(float bound){
    health += Random.Range(0f, bound);
}

public void SetArmor(float bound){
    
    armor += Random.Range(0f, bound);
    
}
}
