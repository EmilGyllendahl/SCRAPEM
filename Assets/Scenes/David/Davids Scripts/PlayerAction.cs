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
            Instantiate(TireMine, transform.position - new Vector3(0, 0, 3), quaternion.identity);
        }
    }
}
