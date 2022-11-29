using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TireMine : MonoBehaviour
{
    public GameObject explosionPrefab;
    private AudioSource m_exploadingSound;
    public MeshRenderer tire;



    // Start is called before the first frame update
    void Start()
    {
        m_exploadingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Start explosion");
            m_exploadingSound.Play();
            Instantiate(explosionPrefab, transform.position, quaternion.identity);
            Invoke("DestroyTireMine", .1f);

        }
        
    }

    void DestroyTireMine()
    {
        //gameObject.SetActive(false);
        //Destroy(gameObject);
        tire.enabled = false;
        
    }
    
    
}
