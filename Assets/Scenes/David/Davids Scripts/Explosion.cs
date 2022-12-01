using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    public MeshRenderer exploadingBarrel;
    private AudioSource m_exploadingSound;
    
    // Start is called before the first frame update
    void Start()
    {
        m_exploadingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.CompareTag("Exploading"))
        {
            Debug.Log("Start barrel explosion");
            m_exploadingSound.Play();
            Instantiate(explosionPrefab, transform.position, quaternion.identity);
            Invoke("DestroyExploading", .1f); 
        }
        
    }
    

    void DestroyExploading()
    {
        exploadingBarrel.enabled = false;
        //Destroy(gameObject);
    }

   
    
}
