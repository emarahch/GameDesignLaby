using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

public GameObject knife;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
             Instantiate(knife, transform.position, transform.rotation);
     }


}
