using UnityEngine;

[CreateAssetMenu]

public class floatData : ScriptableObject
{

    public float value;

    public void UpdateValue(float num) 
    {

        value += num;

    }

    public void UpdateAmmoCount(float ammo)
    {

        value += ammo;

    }

}