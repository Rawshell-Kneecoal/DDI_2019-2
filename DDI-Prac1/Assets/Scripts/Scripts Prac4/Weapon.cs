using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Inventario/Items/Weapon")] // to add menu in unity, copied from item script
public class Weapon : Item
{
    public override void Use() {
        base.Use();
        Debug.Log("Using weapon, must appear on the scene");
    }
}
