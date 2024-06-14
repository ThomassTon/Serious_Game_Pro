using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

  public Text nameText;
  public Text attackText;
  public Text hpText;
  public Image backgroundImage;
  public Image attack_icon;
  public Text attriText;
  public Image hp_icon;

  public Card card;
    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.cardName;
        if(card is MonsterCard)
        {
            var monster = card as MonsterCard;
            attackText.text = monster.attack.ToString();
            hpText.text = monster.hp.ToString();
            attriText.text = monster.attri.ToString();
        }
        else if(card is MainMatrialCard)
        {
            var main_matrial = card as MainMatrialCard;
            attackText.text = main_matrial.attack.ToString();
            attriText.text = main_matrial.attri.ToString();

            hpText.gameObject.SetActive(false);
            hp_icon.gameObject.SetActive(false);
        }
        else if(card is ToppingCard)
        {
            var topping = card as ToppingCard;
            attackText.text = topping.attack.ToString();
            attriText.text = topping.attri.ToString();
            hpText.gameObject.SetActive(false);
            hp_icon.gameObject.SetActive(false);
        }
    }
}
