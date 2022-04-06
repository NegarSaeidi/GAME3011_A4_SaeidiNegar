using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckForWin : MonoBehaviour
{
    public static bool checkForHintWin;
    public GameObject[] passcodePins;
    void Start()
    {

       
            

    }

   
    void Update()
    {
        if (GeneratePasscode.passcodeGenerated)
        {
            passcodePins = GameObject.FindGameObjectsWithTag("Passcode");
            checkForHintWin = true;
          
        }
        if (checkForHintWin)
        {
         
            checkWinCondition();
            print(CheckForExisitingColors());
        }
    }
    private void checkWinCondition()
    {
        int j = 0;
        bool[] pins= new bool[5];
        for (int i = GridGeneration.LasttIndexClicked - 4; i <= GridGeneration.LasttIndexClicked; i++)
        {
            if (GridGeneration.tilesList[i].transform.GetChild(0).GetComponent<Image>().sprite== passcodePins[j].transform.GetChild(0).GetComponent<Image>().sprite )
                pins[j] = true;
            j++;
        }
        
         if(pins[0] && pins[1] && pins[2] && pins[3] && pins[4] )
        {
            print("WIN");
        }
       
    }

    private int CheckForExisitingColors()
    {
        int index = 0;
        bool[] pinColors = new bool[5];
        int counter = 0;
        for (int i = 0; i < passcodePins.Length; i++)
        {
            for (int j = GridGeneration.LasttIndexClicked - 4; j <= GridGeneration.LasttIndexClicked; j++)
            {
               
                    if (passcodePins[i].transform.GetChild(0).GetComponent<Image>().sprite == GridGeneration.tilesList[j].transform.GetChild(0).GetComponent<Image>().sprite)
                {
                    pinColors[index] = true;
                  
                }
                   

            }
            index++;
        }
        for (int i = 0; i <5; i++)
        {
            if (pinColors[i])
                counter++;
        }
        return counter;
    }
}
