using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSecneManager : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterInfo info;
    List<Dictionary<string, object>> infoData = new List<Dictionary<string, object>>();
    GameManager gamemanager;
    Calendar calendar;
    int totalDay;
    int month;
    int day;
    private void Start()
    {
        ReadBonusInfo();
        gamemanager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
        calendar = GameObject.Find("GameManager").transform.GetComponent<Calendar>();
        GetTotalDay();
    }


    public void ReadBonusInfo()
    {
        CSVReader.Read("ZodiacData");
    }
    public void GetTotalDay()
    {
        SpecialDay birthday = new SpecialDay();
        birthday.month = 3;
        birthday.day = 21;
        gamemanager.birthday = birthday;
        calendar.GetTotalDayFromBirthDay(birthday);
        Debug.Log(calendar.dayTotal);
        birthday.month = 4;
        birthday.day = 19;
        gamemanager.birthday = birthday;
        calendar.GetTotalDayFromBirthDay(birthday);
        Debug.Log(calendar.dayTotal);
    }
    public void GetZodiac()
    {
        calendar.GetTotalDayFromBirthDay(gamemanager.birthday);
        if (totalDay >= 20 && totalDay <= 49)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Aquarius);
        }
        else if (totalDay > 49 && totalDay <= 79)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Pisces);
        }
        else if (totalDay > 79 && totalDay <= 109)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Aries);
        }
        else if (totalDay > 109 && totalDay <= 140)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Taurus);
        }
        else if (totalDay > 140 && totalDay <= 172)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Gemini);
        }
        else if (totalDay > 172 && totalDay <= 203)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Cancer);
        }
        else if (totalDay > 203 && totalDay <= 234)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Leo);
        }
        else if (totalDay > 234 && totalDay <= 266)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Virgo);
        }
        else if (totalDay > 266 && totalDay <= 295)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Libra);
        }
        else if (totalDay > 295 && totalDay <= 326)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Scorpio);
        }
        else if (totalDay > 326 && totalDay <= 358)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Archer);
        }
        else// if (totalDay > 358 || totalDay < 20)
        {
            gamemanager.characterInfo.SetZodiac(Zodiac.Capricorn);
        }
        
    }
    public void GetZodiacBonus()
    {
        
        switch (gamemanager.characterInfo.GetZodiac())
        {
            case Zodiac.Capricorn:
                break;
            case Zodiac.Aquarius:
                break;
            case Zodiac.Pisces:
                break;
            case Zodiac.Aries:
                break;
            case Zodiac.Taurus:
                break;
            case Zodiac.Gemini:
                break;
            case Zodiac.Cancer:
                break;
            case Zodiac.Leo:
                break;
            case Zodiac.Virgo:
                break;
            case Zodiac.Libra:
                break;
            case Zodiac.Scorpio:
                break;
            case Zodiac.Archer:
                break;
            default:
                break;
        }
    }

    public void SetCharactorStatus(int zodiacNumber)
    {
        infoData = CSVReader.Read("ZodiacData");
        info.SetConstitution(int.Parse(infoData[zodiacNumber]["Constitution"].ToString()));
        info.SetStrength(int.Parse(infoData[zodiacNumber]["Strength"].ToString()));
        info.SetIntelligence(int.Parse(infoData[zodiacNumber]["Intelligence"].ToString()));
        info.SetRefinement(int.Parse(infoData[zodiacNumber]["Refinement"].ToString()));
        info.SetCharisma(int.Parse(infoData[zodiacNumber]["Charisma"].ToString()));
        info.SetMoral(int.Parse(infoData[zodiacNumber]["Moral"].ToString()));
        info.SetFaith(int.Parse(infoData[zodiacNumber]["Faith"].ToString()));
        info.SetSens(int.Parse(infoData[zodiacNumber]["Sens"].ToString()));
        info.SetFighter(int.Parse(infoData[zodiacNumber]["Fighter"].ToString()));
        info.SetCombatSkill(int.Parse(infoData[zodiacNumber]["CombatSkill"].ToString()));
        info.SetCombatAttack(int.Parse(infoData[zodiacNumber]["CombatAttack"].ToString()));
        info.SetCombatDefense(int.Parse(infoData[zodiacNumber]["CombatDefense"].ToString()));
        info.SetMagician(int.Parse(infoData[zodiacNumber]["Magician"].ToString()));
        info.SetMagicalSkill(int.Parse(infoData[zodiacNumber]["MagicalSkill"].ToString()));
        info.SetMagicalAttack(int.Parse(infoData[zodiacNumber]["MagicalAttack"].ToString()));
        info.SetMagicalDefense(int.Parse(infoData[zodiacNumber]["MagicalDefense"].ToString()));
        info.SetSocial(int.Parse(infoData[zodiacNumber]["Social"].ToString()));
        info.SetDecorum(int.Parse(infoData[zodiacNumber]["Decorum"].ToString()));
        info.SetArt(int.Parse(infoData[zodiacNumber]["Art"].ToString()));
        info.SetConversation(int.Parse(infoData[zodiacNumber]["Conversation"].ToString()));
        info.SetHouseWork(int.Parse(infoData[zodiacNumber]["HouseWork"].ToString()));
        info.SetCooking(int.Parse(infoData[zodiacNumber]["Cooking"].ToString()));
        info.SetCleaning(int.Parse(infoData[zodiacNumber]["Cleaning"].ToString()));
        info.SetTemperament(int.Parse(infoData[zodiacNumber]["Temperament"].ToString()));
    }
}
