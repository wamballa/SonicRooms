using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] itemsToVanish;

    public GameObject sonicNew;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource.Play();
        sonicNew.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject go in itemsToVanish)
            {
                go.SetActive(false);
                sonicNew.SetActive(true);
            }
        }
    }
}
