using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterInfo characterInfo;
    List<Dictionary<string,object>> zodiacData;
    void Start()
    {
        characterInfo = this.gameObject.GetComponent<CharacterState>().characterInfo;
        GetZodiacData("ZodiacData",characterInfo.GetZodiac());
        Debug.Log(characterInfo);
    }

    public void GetZodiacData(string path,Zodiac zodiac)
    {
        zodiacData = CSVReader.Read(path);
        characterInfo.SetConstitution((int)zodiacData[(int)zodiac]["Constitution"]);
        characterInfo.SetStrength((int)zodiacData[(int)zodiac]["Strength"]);
        characterInfo.SetIntelligence((int)zodiacData[(int)zodiac]["Intelligence"]);
        characterInfo.SetRefinement((int)zodiacData[(int)zodiac]["Refinement"]);
        characterInfo.SetCharisma((int)zodiacData[(int)zodiac]["Charisma"]);
        characterInfo.SetMoral((int)zodiacData[(int)zodiac]["Moral"]);
        characterInfo.SetFaith((int)zodiacData[(int)zodiac]["Faith"]);
        characterInfo.SetSens((int)zodiacData[(int)zodiac]["Sens"]);
        characterInfo.SetFighter((int)zodiacData[(int)zodiac]["Fighter"]);
        characterInfo.SetCombatSkill((int)zodiacData[(int)zodiac]["CombatSkill"]);
        characterInfo.SetCombatAttack((int)zodiacData[(int)zodiac]["CombatAttack"]);
        characterInfo.SetCombatAttack((int)zodiacData[(int)zodiac]["CombatAttack"]);
        characterInfo.SetCombatDefense((int)zodiacData[(int)zodiac]["CombatDefense"]);
        characterInfo.SetMagician((int)zodiacData[(int)zodiac]["Magician"]);
        characterInfo.SetMagicalSkill((int)zodiacData[(int)zodiac]["MagicalSkill"]);
        characterInfo.SetMagicalAttack((int)zodiacData[(int)zodiac]["MagicalAttack"]);
        characterInfo.SetMagicalDefense((int)zodiacData[(int)zodiac]["MagicalDefense"]);
        characterInfo.SetSocial((int)zodiacData[(int)zodiac]["Social"]);
        characterInfo.SetDecorum((int)zodiacData[(int)zodiac]["Decorum"]);
        characterInfo.SetConversation((int)zodiacData[(int)zodiac]["Conversation"]);
        characterInfo.SetHouseWork((int)zodiacData[(int)zodiac]["Housework"]);
        characterInfo.SetCooking((int)zodiacData[(int)zodiac]["Cooking"]);
        characterInfo.SetCleaning((int)zodiacData[(int)zodiac]["Cleaning"]);
        characterInfo.SetTemperament((int)zodiacData[(int)zodiac]["Temperament"]);
        characterInfo.SetSin((int)zodiacData[(int)zodiac]["Sin"]);
        characterInfo.SetStress((int)zodiacData[(int)zodiac]["Stress"]);

    }

}
