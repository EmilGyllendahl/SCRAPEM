using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomisationScript : MonoBehaviour
{
    public GameObject vehicle;
    public Weapons ws;

    private void FixedUpdate()
    {
        vehicle.transform.Rotate(new Vector3(0,0.5f,0));
    }

    public void WeaponSelected(int index)
    {
        ws.SetWeapon(index);
    }
}
