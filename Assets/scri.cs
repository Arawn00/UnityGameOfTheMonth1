using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    life = 3;
    public int cooldown = 10;
    public float cooldownup = 0.0f;
    private int add = 1;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += cooldownup;
    }
}
