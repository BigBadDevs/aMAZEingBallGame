using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayScript : MonoBehaviour
{
    public Transform box;
    public CanvasGroup backGround;

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        backGround.alpha = 0;
        backGround.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }
    //
    public void ClosePanel() 
    {
        backGround.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseOutExpo();
    }
}
