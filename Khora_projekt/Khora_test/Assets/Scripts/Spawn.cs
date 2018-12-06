using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public int max;
    public GameObject ring;
    private float horizontalMin = -50f;
    private float horizontalMax = -30f;

    private float yposMin = 1.0f;
    private float yposMax = 2.5f;
    public Text winText;
    private float verticalMin = 3f;
    private float verticalMax = 5f;
    private float SpawnTime = 1.5f;


    private Vector3 orginPosition;
    // Use this for initialization1
    void Start()
    {

        orginPosition = transform.position;
        StartCoroutine(CountD(5));      // Countdown
        ring.SetActive(false);          // remove first ring
        winText.text = "";
        bool state = ring.gameObject.activeSelf;
        //if (state == true)
        //{
        //StartCoroutine(Spawnwait(max));
        //}
        //print("state: " + state);
    }

    IEnumerator CountD(int seconds)
    {
        int count = seconds;

        while (count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;

        }

        ring.SetActive(true);
        StartCoroutine(Spawnwait(max));
        //InvokeRepeating("SpawnFunction", SpawnTime, SpawnTime);


    }

    void SpawnFunction()
    {
       
            Vector3 randomPosition = new Vector3(Random.Range(horizontalMin, horizontalMax), Random.Range(yposMin, yposMax), Random.Range(verticalMin, verticalMax));
            Instantiate(ring, randomPosition, Quaternion.identity);
            orginPosition = randomPosition;
    }

    IEnumerator Spawnwait(int max)
    {
        int count = 0;
        while (count < max)
        {
            print("Count:  " + count);
            SpawnFunction();
            yield return new WaitForSeconds(SpawnTime);
            count++;

        }
        if (count > 1)
        {
            winText.text = "You Win";
        }
    }
}
