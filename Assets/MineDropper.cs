using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MineDropper : MonoBehaviour
{
    [SerializeField] public GameObject TireMine;
    [SerializeField] public Transform MineDrop;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(TireMine, MineDrop.position, quaternion.identity);
        }
    }
}
