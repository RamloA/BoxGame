using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flying : MonoBehaviour
{
    private float horizontalSpeed = 0.2f;
    public Vector3 tempPosition;
    bool start1;

    public GameObject ring;

  //  public Text countText;

    // Use this for initialization
    void Start()
    {
        ring.gameObject.SetActive(true); 
       start1 = ring.gameObject.activeSelf;
        print("active " + start1);

        transform.Rotate(180, -89, 0); //rotate ring object
        
        if (start1 == true)
        {
          //  countText.enabled = false;
            tempPosition = transform.position;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.x += horizontalSpeed;

        transform.position = tempPosition;
    }
   
}
