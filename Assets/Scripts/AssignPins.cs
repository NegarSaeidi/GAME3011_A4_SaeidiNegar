using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AssignPins : MonoBehaviour
{
    public static bool clicked;
 
    public void ClickOnPin()
    {
        for (int i = 0; i < GridGeneration.gridSize*5; i++)
        {

            if (GridGeneration.tilesList[i].transform == gameObject.transform)
            {
                GridGeneration.selectedTile = i;
                GridGeneration.tilesList[i].gameObject.transform.Find("Hint").gameObject.SetActive(true);
                clicked = true;
            }
            else
                GridGeneration.tilesList[i].GetComponent<Button>().interactable = false;


        }
     
       
       
    }
}
