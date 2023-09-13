using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(fileName = "Plane Weapon")]
public class Weapon : ScriptableObject
{
    public string WeaponName;

    public float CurrentAmmo;
    public float MagSize;

    public float Damage;
    public float RateOfFire;
    public float BulletsPerShot; // used for burst weapons

    public float ReloadTime;

    public int[] PlaneSpawnLocationIDs;
}
