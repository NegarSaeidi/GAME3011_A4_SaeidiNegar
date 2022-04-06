using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickOnPins : MonoBehaviour
{
 
    public void ClickOnPin()
    {
         GridGeneration.tilesList[GridGeneration.selectedTile].transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<Image>().sprite;
        Color color = GridGeneration.tilesList[GridGeneration.selectedTile].transform.GetChild(0).GetComponent<Image>().color;
         GridGeneration.tilesList[GridGeneration.selectedTile].transform.GetChild(0).GetComponent<Image>().color = new Color(color.r, color.g, color.b, 255);

        GridGeneration.tilesList[GridGeneration.selectedTile].gameObject.transform.Find("Hint").gameObject.SetActive(false);
        ReActivateTiles();
    }
    private void ReActivateTiles()
    {
        for(int i= GridGeneration.LasttIndexClicked-4; i<= GridGeneration.LasttIndexClicked; i++)
            GridGeneration.tilesList[i].GetComponent<Button>().interactable = true;

    }
  
}
