public class Card
{
    public int id;
    public string cardName;
    public Card(int _id, string _cardName)
    {
        this.id = _id;
        this.cardName = _cardName;
    }


}

public class MonsterCard: Card
{
    public int attack;
    public int hp;
    public int hp_max;
    public string attri;
    public MonsterCard(int _id, string _cardName, int _attack, int _hp, int _hp_max, string _attri) :base(_id, _cardName)
    {
        this.attack= _attack;
        this.hp= _hp;
        this.hp_max= _hp_max;
        this.attri = _attri;
    }

}

public class MainMatrialCard: Card
{
    public int attack;
    public string attri;
    public MainMatrialCard(int _id, string _cardName,int _attack, string _attri):base (_id, _cardName)
    {
        this.attack = _attack;
        this.attri = _attri;

    }
} 

public class ToppingCard: Card
{
    public int attack;
    public string attri;
    public ToppingCard(int _id, string _cardName, int _attack, string _attri) : base(_id, _cardName)
    {
      this.attack = _attack;
      this.attri = _attri;
    }
}
