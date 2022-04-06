using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActivateNextRow : MonoBehaviour
{
    private bool[] tileIsSet;
   public static bool openNextRow;
    public GameObject gameoverPanel;
    void Start()
    {
        tileIsSet = new bool[5];
    }

   
    void Update()
    {
        var index = 0;
        for (int i = 0; i < 5; i++)
            tileIsSet[i] = false;
        if (!GridGeneration.regenerateTiles)
        {
            for (int i = GridGeneration.LasttIndexClicked - 4; i <= GridGeneration.LasttIndexClicked; i++)
            {
                if (GridGeneration.tilesList[i].transform.GetChild(0).GetComponent<Image>().sprite)
                {
                    tileIsSet[index] = true;

                }
                index++;
            }
            if (tileIsSet[0] && tileIsSet[1] && tileIsSet[2] && tileIsSet[3] && tileIsSet[4])
            {
                CheckForWin.checkForHintWin = true;
                for (int i = GridGeneration.LasttIndexClicked - 4; i <= GridGeneration.LasttIndexClicked; i++)
                    GridGeneration.tilesList[i].GetComponent<Button>().interactable = false;



            }
            if (openNextRow)
            {
                openNextRow = false;
                CheckForWin.checkForHintWin = false;
                if (GridGeneration.LasttIndexClicked== GridGeneration.tilesList.Count-1)
                {
                    gameoverPanel.SetActive(true);
                }
                else
                {
                    GridGeneration.LasttIndexClicked += 5;
                    print("----" + GridGeneration.LasttIndexClicked);

                    for (int i = GridGeneration.LasttIndexClicked - 4; i <= GridGeneration.LasttIndexClicked; i++)
                        GridGeneration.tilesList[i].GetComponent<Button>().interactable = true;
                }
               

            }
        }
    }
}
