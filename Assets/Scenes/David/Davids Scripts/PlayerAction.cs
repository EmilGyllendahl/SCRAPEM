using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] public GameObject TireMine;
   
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            GetComponent<Gun>().Shoot();

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(TireMine, transform.position - new Vector3(-4f, 1.25f, -0.5f), quaternion.identity);
        }
    }
}
