using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    public GameObject ConsoleCanvas;
    public TMP_InputField InputField;
    public TMP_Text OutputText;
    public Button SendBtn;

    public Client Network;

    private bool _isConsoleOpen = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote) && !_isConsoleOpen)
        {
            ConsoleCanvas.active = _isConsoleOpen = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (Input.GetKeyDown(KeyCode.BackQuote) && _isConsoleOpen)
        {
            ConsoleCanvas.active = _isConsoleOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        string[] SplitText;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SplitText = InputField.text.Split(new string[] { " ", ":" }, StringSplitOptions.None);

            switch (SplitText[0])
            {
                case "connect":
                    string Ip = SplitText[1];
                    int Port = int.Parse(SplitText[2]);

                    print(Ip + ":" + Port);

                    bool status = Network.CreateConnect(Ip, Port);

                    if (status)
                        OutputText.text += "\n\r[" + DateTime.UtcNow + "] [Network] Connected succesfully";
                    else
                        OutputText.text += "\n\r[" + DateTime.UtcNow + "] [Network] Connection could not be create";

                    break;
            }
        }
    }
}
