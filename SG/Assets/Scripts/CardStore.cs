using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStore : MonoBehaviour
{
    public TextAsset cardData;
    public List<Card> cardlist = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        LoadCardData();
        //TestLoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadCardData()
    {
        string[] dataRow = cardData.text.Split('\n');
        foreach(var row in dataRow)
        {
            string[] rowArray = row.Split(',');
            if (rowArray[0] == "#") {
              continue;
            }
            else if(rowArray[0] == "monster") {
              //create card
              int id = int.Parse(rowArray[1]);
              string name = rowArray[2];
              int atk = int.Parse(rowArray[3]);
              int hp = int.Parse(rowArray[4]);
              string attri = rowArray[5];
              MonsterCard monsterCard = new MonsterCard(id, name, atk, hp, hp,attri);
              cardlist.Add(monsterCard);
              //Debug.Log("read  :"+ monsterCard.cardName);
            }
            else if(rowArray[0] == "MainMaterial") {
              //
              int id = int.Parse(rowArray[1]);
              string name =  rowArray[2];  
              int atk = int.Parse(rowArray[3]);
              string attri = rowArray[4];
              MainMatrialCard mainMatrialCard = new MainMatrialCard(id, name, atk, attri);
              cardlist.Add(mainMatrialCard);
              //Debug.Log("read  :"+ mainMatrialCard.cardName);
            }
            else if(rowArray[0] == "Topping") {
              //
              int id = int.Parse(rowArray[1]);
              string name =  rowArray[2];  
              int atk = int.Parse(rowArray[3]);
              string attri = rowArray[4];
              ToppingCard toppingCard = new ToppingCard(id, name, atk, attri);
              cardlist.Add(toppingCard);
              //Debug.Log("read  :"+ toppingCard.cardName);
            }
        }
    }
    public void TestLoad()
    {
      foreach(var item in cardlist)
      {
        Debug.Log(item.cardName);
      }
    }
}
