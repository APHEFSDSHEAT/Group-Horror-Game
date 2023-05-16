using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] public bool nearCloset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearCloset = true;
    }

    public void GetInCloset()
    {
        //if (Input.GetKeyDown(a)
        
            
        
    }

}
