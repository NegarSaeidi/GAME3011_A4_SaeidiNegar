using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public GameObject lastPasscodePin;

    public static int pinCount;
    private void Start()
    {
        pinCount = 4;
    }
    public void OnBeginner()
    {
        GeneratePasscode.regeneratePasscode = true;
        lastPasscodePin.gameObject.SetActive(false);
        pinCount = 4;
    }
    public void OnAdvanced()
    {
        GeneratePasscode.regeneratePasscode = true;
        lastPasscodePin.gameObject.SetActive(true);
        pinCount = 5;
    }
}
