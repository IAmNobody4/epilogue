using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    //[SerializeField]
    Canvas MenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        MenuCanvas = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
        MenuCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!MenuCanvas.isActiveAndEnabled)
            {
                MenuCanvas.gameObject.SetActive(true);
            }
            else {
                MenuCanvas.gameObject.SetActive(false);
            }

        }
    }
}
