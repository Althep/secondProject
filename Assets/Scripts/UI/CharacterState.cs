using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Zodiac{
    Capricorn,
    Aquarius,
    Pisces,
    Aries,
    Taurus,
    Gemini,
    Cancer,
    Leo,
    Virgo,
    Libra,
    Scorpio,
    Archer
}

public class CharacterInfo
{
    string name;
    int Constitution;
    int Strength;
    int Intelligence;
    int Refinement;
    int Charisma;
    int Moral;
    int Faith;
    int Sens;
    int Fighter;
    int CombatSkill;
    int CombatAttack;
    int CombatDefense;
    int Magician;
    int MagicalSkill;
    int MagicalAttack;
    int MagicalDefense;
    int Decorum;
    int Conversation;
    int HouseWork;
    int Cooking;
    int Cleaning;
    int Temperament;
    int Sin;
    int Stress;
    Zodiac zodiac;
    public string GetName()
    {
        return name;
    }
    public void SetName(string value)
    {
        name = value;
    }
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

    public Zodiac GetZodiac()
    {
        return zodiac;
    }
    public void SetZodiac(Zodiac zod)
    {
        zodiac = zod;
    }
    
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
    public CharacterInfo characterInfo = new CharacterInfo();
}
