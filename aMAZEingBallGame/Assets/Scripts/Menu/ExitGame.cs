using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void CloseGame()
    {
        Debug.Log("Quit activated");
        Application.Quit();
    }
}
