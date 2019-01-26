using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvasController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
