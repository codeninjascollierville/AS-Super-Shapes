using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
[Header("Rigidbody Object")]
public Rigidbody2D rb;
[Header("Default Shrinking Speed")]
public float shrinkspeed = 3f;
}

    // Start is called before the first frame update
    void Start()
    {
     rb.roation = Random.Range(0f, 360f);
     transform.localScale = vector3.one * 10f;
    }
    
    // Update is called once per frame
    void Update()
    {
    
      transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
      if(transform.localScale.x <= .05f);
    {
  
        // Destroy object
        Destroy(gameObject);
  }

  }
          
    


   // {

  //  }
