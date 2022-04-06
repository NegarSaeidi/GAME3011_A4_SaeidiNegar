using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridGeneration : MonoBehaviour
{


    public GameObject tilePrefab;
    public static List<GameObject> tilesList;
    public GameObject tileParent;
    public static int selectedTile;
    public static int gridSize;
    public static int LasttIndexClicked;
    public static bool regenerateTiles;
    void Start()
    {
        gridSize = 10;
        tilesList = new List<GameObject>();
        generateTiles(gridSize); 
    }

 
    void Update()
    {
        if(regenerateTiles)
        {
           
            DestoryTiles();
            generateTiles(gridSize);
            regenerateTiles = false;

        }
    }

  
    private void generateTiles(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                GameObject newTile = Instantiate(tilePrefab, new Vector3(0, 0, 0), Quaternion.identity);
                newTile.gameObject.transform.SetParent(tileParent.gameObject.transform);
                if (i != 1)
                    newTile.GetComponent<Button>().interactable = false;
                tilesList.Add(newTile);
                LasttIndexClicked = 4;


            }




        }
    }
    private void DestoryTiles()
    {
        
            for (int j = 0; j <tilesList.Count; j++)
            {


            Destroy(tilesList[j].gameObject);

         
         



  
            }
        tilesList.Clear();
    }
}
