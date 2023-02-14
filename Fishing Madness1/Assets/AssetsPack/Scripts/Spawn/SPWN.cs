using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPWN : MonoBehaviour
{
    public GameObject fish;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(fish, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
