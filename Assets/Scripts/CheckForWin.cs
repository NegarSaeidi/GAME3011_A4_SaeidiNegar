using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckForWin : MonoBehaviour
{
    public static bool checkForHintWin;
    public GameObject[] passcodePins;
    public GameObject cover;
    void Start()
    {

       
            

    }

   
    void Update()
    {
        if (GeneratePasscode.passcodeGenerated)
        {
            passcodePins = GameObject.FindGameObjectsWithTag("Passcode");
           
          
        }
        if (checkForHintWin)
        {
          
            checkWinCondition();
            CheckForExisitingColors();
            ActivateNextRow.openNextRow = true;
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
            cover.gameObject.SetActive(false);
            print("WIN");
        }
       
    }

    private void CheckForExisitingColors()
    {
        int index = 0;
        bool[] pinColors = new bool[5];
        bool[] pinColorsAndPlace = new bool[5];
        int colorCounter = 0;
        int placeCounter = 0;
        for (int j = GridGeneration.LasttIndexClicked - 4; j <= GridGeneration.LasttIndexClicked; j++)
    
        {
            for (int i = 0; i < passcodePins.Length; i++)
            {
               
                    if (passcodePins[i].transform.GetChild(0).GetComponent<Image>().sprite == GridGeneration.tilesList[j].transform.GetChild(0).GetComponent<Image>().sprite)
                {
                    pinColors[index] = true;
                    if ((i % 5) == (j % 5))
                        pinColorsAndPlace[index] = true;
                 
                       
                    
                }
                   

            }
            index++;
        }
        for (int i = 0; i < 5; i++)
        {
            if (pinColors[i])
                colorCounter++;
        }
        for (int i = 0; i <5; i++)
        {
            if (pinColorsAndPlace[i])
                placeCounter++;
        }
        print(colorCounter+ " colors are correct and " + placeCounter +" color and place");
    }
}
