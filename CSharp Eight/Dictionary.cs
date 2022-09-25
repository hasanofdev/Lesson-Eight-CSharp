using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary;
internal class MyDictionary
{
    public List<string> keys;
    public List<string> values;

    public MyDictionary()
    {
        keys = new() { "Greeting", "The Alphabet", "Punctuation", "Writing", "Numbers", "Body", "Face", "Organ", "Skeleton", "Medicine", "Clothes", "Jewelry", "Sewing", "Fruit", "Vegetable", "Food", "Drink", "Sweet", "Animal", "Pet", "Insect", "Bird", "Mammal", "Reptile", "Sea", "Plant", "Landscape", "Weather", "Camp", "House", "Door" };
        values = new() { "Salamlaşmaq", "Hərflər", "Durğu", "Yazmaq", "Rəqəmlər", "Bədən", "Üz", "Orqan", "Skelet", "Tibbi", "Paltar", "Zinət", "Tikiş", "Meyvə", "Tərəvəz", "Qida", "İçki", "Şirniyat", "Heyvan", "Ev Heyvanı", "Həşərat", "Quş", "Məməli", "Sürünən", "Dəniz", "Bitki", "Mənzərə", "Hava", "Kamp", "Ev", "Qapı" };
    }


    public string this[string key]
    {
        get
        {
            for (int i = 0; i < keys.Count; i++)
                if (keys[i] == key)
                    return values[i];
            return "";
        }
    }
}
