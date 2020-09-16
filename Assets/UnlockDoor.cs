﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject platform;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

      void OnTriggerEnter2D (Collider2D col) {

          if (col.gameObject.tag == "Player")
          {
              Destroy(platform);
              anim.SetTrigger("ButtonPress");
         
          }

      }
    
}
