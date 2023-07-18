using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum Sign{
    Capricorn,
    Verseau,
    Poissons,
    Mouton,
    Taurus,
    Gemini,
    Cancer,
    Leo,
    Virgo,
    Libra,
    Scorpio,
    Archer


}

public class characterStat 
{
    int Constitution;
    public int GetConstitution()
    {
        return Constitution;
    }
    public void SetConstitution(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Constitution = value;
    }


    int Strength;
    public int GetStrength()
    {
        return Strength;
    }
    public void SetStrength(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Strength = value;
    }


    int Intelligence;
    public int GetIntelligence()
    {
        return Intelligence;
    }
    public void SetIntelligence(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Intelligence = value;
    }


    int Refinement;
    public int GetRefinement()
    {
        return Refinement;
    }
    public void SetRefinement(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Refinement = value;
    }


    int Charisma;
    public int GetCharisma()
    {
        return Charisma;
    }
    public void SetCharisma(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Charisma = value;
    }


    int Moral;
    public int GetMoral()
    {
        return Moral;
    }
    public void SetMoral(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Moral = value;
    }


    int Faith;
    public int GetFaith()
    {
        return Faith;
    }
    public void SetFaith(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Faith = value;
    }


    int Sens;
    public int GetSens()
    {
        return Sens;
    }
    public void SetSens(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Sens = value;
    }


    int Fighter;
    public int GetFighter()
    {
        return Fighter;
    }
    public void SetFighter(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Fighter = value;
    }


    int CombatSkill;
    public int GetCombatSkill()
    {
        return CombatSkill;
    }
    public void SetCombatSkill(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        CombatSkill = value;
    }


    int CombatAttack;
    public int GetCombatAttack()
    {
        return CombatAttack;
    }
    public void SetCombatAttack(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        CombatAttack = value;
    }


    int CombatDefense;
    public int GetCombatDefense()
    {
        return CombatDefense;
    }
    public void SetCombatDefense(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        CombatDefense = value;
    }


    int Magician;
    public int GetMagician()
    {
        return Magician;
    }
    public void SetMagician(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Magician = value;
    }


    int MagicalSkill;
    public int GetMagicalSkill()
    {
        return MagicalSkill;
    }
    public void SetMagicalSkill(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        MagicalSkill = value;
    }


    int MagicalAttack;
    public int GetMagicalAttack()
    {
        return MagicalAttack;
    }
    public void SetMagicalAttack(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        MagicalAttack = value;
    }


    int MagicalDefense;
    public int GetMagicalDefense()
    {
        return MagicalDefense;
    }
    public void SetMagicalDefense(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        MagicalDefense = value;
    }


    int Social;
    public int GetSocial()
    {
        return Social;
    }
    public void SetSocial(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Social = value;
    }


    int Decorum;
    public int GetDecorum()
    {
        return Decorum;
    }
    public void SetDecorum(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Decorum = value;
    }


    int Art;
    public int GetArt()
    {
        return Art;
    }
    public void SetArt(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Art = value;
    }


    int Conversation;
    public int GetConversation()
    {
        return Conversation;
    }
    public void SetConversation(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Conversation = value;
    }


    int HouseWork;
    public int GetHouseWork()
    {
        return HouseWork;
    }
    public void SetHouseWork(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        HouseWork = value;
    }


    int Cooking;
    public int GetCooking()
    {
        return Cooking;
    }
    public void SetCooking(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Cooking = value;
    }


    int Cleaning;
    public int GetCleaning()
    {
        return Cleaning;
    }
    public void SetCleaning(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Cleaning = value;
    }


    int Temperament;
    public int GetTemperament()
    {
        return Temperament;
    }
    public void SetTemperament(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Temperament = value;
    }


    int Sin;
    public int GetSin()
    {
        return Sin;
    }
    public void SetSin(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Sin = value;
    }


    int Stress;
    public int GetStress()
    {
        return Stress;
    }
    public void SetStress(int value)
    {
        if (value >= 999)
        {
            value = 999;
        }
        Stress = value;
    }

}

public class CharacterState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
