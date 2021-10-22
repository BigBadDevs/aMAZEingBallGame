using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkinSelect : MonoBehaviour
{
    public GameObject sun;
    public GameObject ballPivotPoint;
    public Transform ballPosition1;
    public Transform ballPosition2;
    public Transform panelRect;
    public CanvasGroup mainPanelGroup;
    public CanvasGroup skinPanelGroup;

    private int selection = 1;  // get variable from global
    private int skinCount = 4;  // get number of child objects under ball pivot point
                                // ^ also update switch case to be more dynamic with skin amount changes

    private void OnEnable()
    {
        //create a sequence
        Sequence mySequence = DOTween.Sequence();
        Sequence mySequence2 = DOTween.Sequence();
        //(1)shrink sun
        mySequence.Append(sun.transform.DOMoveZ(-452.29f, 3));

        //(1)menu swipes out & alpha -- (happens seperate from the sequence but at the same time as first step)
        mySequence.Join(panelRect.DOMoveX(Screen.width, 3));
        mySequence.Join(mainPanelGroup.DOFade(0, 0.5f));
       
        //(2)selection swipes in from left
        mySequence2.PrependInterval(1);
        mySequence2.Append(ballPivotPoint.transform.DOMove(ballPosition2.position, 2));

        //(3)fade in new panel buttons
        mySequence2.Append(skinPanelGroup.DOFade(1, 2)); 



        //http://dotween.demigiant.com/documentation.php
    }

    public void ClosePanel()
    {
        //create a sequence
        Sequence mySequence = DOTween.Sequence();
        Sequence mySequence2 = DOTween.Sequence();

        //(1) fade out skin panel
        mySequence.Append(skinPanelGroup.DOFade(0, 2));
        
        //(2) selection swipes right out of camera view
        mySequence.Join(ballPivotPoint.transform.DOMove(ballPosition1.position, 2));

        //(2) grow sun
        mySequence.Join(sun.transform.DOMoveZ(-465.24f, 3));

        //(3) menu swipes in & alpha ++
        mySequence.Join(panelRect.DOMoveX(Screen.width / 2, 3));
        mySequence2.PrependInterval(2);
        mySequence2.Append(mainPanelGroup.DOFade(1, 0.5f));

        
        //(4) disable input
        gameObject.SetActive(false);
    }

    public void NextOption()
    {
        //add 1 to selection
        selection++;
        if (selection > skinCount)
        { selection = 1; }

        UpdateSkin();
    }

    public void PrevOption()
    {
        selection--;
        if (selection < 1)
        { selection = 4; }

        UpdateSkin();
    }

    private void UpdateSkin()
    { // maybe turnamount = (skins/360) then rotate to selection * turnamount?
        switch (selection)
        {
            case 1:
                //rotate pivot point (selection * 90)
                ballPivotPoint.transform.DORotate(new Vector3(0, 0, 0), 1);
                break;
            case 2:
                ballPivotPoint.transform.DORotate(new Vector3(0, 270, 0), 1);
                break;
            case 3:
                ballPivotPoint.transform.DORotate(new Vector3(0, 180, 0), 1);
                break;
            case 4:
                ballPivotPoint.transform.DORotate(new Vector3(0, 90, 0), 1);
                break;
        } // TODO: add global variable update for scene load
    }

}
