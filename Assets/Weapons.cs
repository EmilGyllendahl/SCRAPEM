using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public GameObject[] weaponSlots;
    public GameObject[] weapons;

    public void SetWeapon(int index)
    {
        for (int i=0; i<weaponSlots.Length; ++i)
        {
            if (index == i)
            {
                while (weaponSlots[i].transform.childCount > 0)
                {
                    DestroyImmediate(weaponSlots[i].transform.GetChild(0).gameObject);
                }
                var temp = Instantiate(weapons[i], weaponSlots[i].transform);
                temp.transform.localPosition = Vector3.zero;
            }
            else
            {
                while (weaponSlots[i].transform.childCount > 0)
                {
                    DestroyImmediate(weaponSlots[i].transform.GetChild(0).gameObject);
                }
            }
        }
    }

}
