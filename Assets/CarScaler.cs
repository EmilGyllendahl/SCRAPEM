using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScaler : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player.localScale = new Vector3(1, 1, 1);
    }

}
