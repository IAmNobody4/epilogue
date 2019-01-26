using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCanvasController : MonoBehaviour
{
    private string currentScreen;
    private Button[] buttons;
    private Text creditsText;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        buttons = gameObject.GetComponentsInChildren<Button>();
        creditsText = gameObject.transform.Find("CreditsText").GetComponent<Text>();
    }

    void Start()
    {
        creditsText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void DisplayCredits()
    {
        currentScreen = "credits";
        Button[] buttons = gameObject.GetComponentsInChildren<Button>();
        for (int x = 0; x < 5; x++)
        {
            buttons[x].gameObject.SetActive(false);
        }
        creditsText.gameObject.SetActive(true);
    }

    void goBack()
    {

    }
}
