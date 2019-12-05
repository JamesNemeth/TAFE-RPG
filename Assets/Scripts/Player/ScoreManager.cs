using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("Points")]
    public Text scoretext;

    public int points, selectedIndex = 10;

    private GameObject[] IncreaseText;
    private GameObject[] DecreaseText;

    [System.Serializable]
    public struct Stats
    {
        public string statName;
        public int statValue;
        public int tempStat;
    };

    [Header("Stats")]
    
    public Stats[] playerStats = new Stats[6];
    public CharacterClass charClass;

    public Text CharClassText;

    public Text Strength;
    public Text Dexterity;
    public Text Constitution;
    public Text Wisdom;
    public Text Intellegence;
    public Text Charisma;


    public void Start()
    {
        IncreaseText = GameObject.FindGameObjectsWithTag("Increasetext");
        DecreaseText = GameObject.FindGameObjectsWithTag("Decreasetext");

        selectedIndex = 0;
        points = 10;
    }
    
    public void ActivateIncreasedText(bool activate)
    {
        foreach (var text in IncreaseText)
        {
            text.gameObject.SetActive(activate);
        }
    }
    public void ActivateDecreaseText(bool activate)
    {
        foreach (var text in DecreaseText)
        {
            text.gameObject.SetActive(activate);
        }
    }
    
    public void Update()
    {
        Strength.text = playerStats[0].statName + ": " + (playerStats[0].statValue+playerStats[0].tempStat);
        Dexterity.text = playerStats[1].statName + ": " + (playerStats[1].statValue + playerStats[1].tempStat);
        Constitution.text = playerStats[2].statName + ": " + (playerStats[2].statValue + playerStats[2].tempStat);
        Wisdom.text = playerStats[3].statName + ": " + (playerStats[3].statValue + playerStats[3].tempStat);
        Intellegence.text = playerStats[4].statName + ": " + (playerStats[4].statValue + playerStats[4].tempStat);
        Charisma.text = playerStats[5].statName + ": " + (playerStats[5].statValue + playerStats[5].tempStat);


        scoretext.text = "Points: " + points;

        CharClassText.text = "" + charClass.ToString();

    }

    public void StatsDown(int s)
    {
        if(points < 10 && playerStats[s].tempStat > 0)
        {
            points++;
            playerStats[s].tempStat--;

        }
       
    }

    public void StatsUp(int s)
    {
       if(points > 0)
        {
            points--;
            playerStats[s].tempStat++;

        }
    }
    public void ChangeClassDown()
    {
        selectedIndex--;
        if (selectedIndex < 0)
        {
            selectedIndex = 11;
        }
        ChooseClass(selectedIndex);
    }
    public void ChangeClassUp()
    {
        selectedIndex++;
        if (selectedIndex > 11)
        {
            selectedIndex = 0;
        }
        ChooseClass(selectedIndex);
    }
    
    void ChooseClass(int className)
    {
        switch (className)
        {
            case 0:
                playerStats[0].statValue = 15;
                playerStats[1].statValue = 10;
                playerStats[2].statValue = 10;
                playerStats[3].statValue = 10;
                playerStats[4].statValue = 10;
                playerStats[5].statValue = 5;
                charClass = CharacterClass.Barbarian;
                break;
            case 1:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 10;
                playerStats[2].statValue = 10;
                playerStats[3].statValue = 10;
                playerStats[4].statValue = 10;
                playerStats[5].statValue = 15;
                charClass = CharacterClass.Bard;
                break;
            case 2:
                playerStats[0].statValue = 10;
                playerStats[1].statValue = 5;
                playerStats[2].statValue = 15;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 5;
                playerStats[5].statValue = 10;
                charClass = CharacterClass.Cleric;
                break;
            case 3:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 10;
                playerStats[2].statValue = 10;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 15;
                playerStats[5].statValue = 5;
                charClass = CharacterClass.Druid;
                break;
            case 4:
                playerStats[0].statValue = 15;
                playerStats[1].statValue = 15;
                playerStats[2].statValue = 10;
                playerStats[3].statValue = 10;
                playerStats[4].statValue = 5;
                playerStats[5].statValue = 5;
                charClass = CharacterClass.Fighter;
                break;
            case 5:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 15;
                playerStats[2].statValue = 15;
                playerStats[3].statValue = 10;
                playerStats[4].statValue = 10;
                playerStats[5].statValue = 5;
                charClass = CharacterClass.Monk;
                break;
            case 6:
                playerStats[0].statValue = 15;
                playerStats[1].statValue = 15;
                playerStats[2].statValue = 15;
                playerStats[3].statValue = 5;
                playerStats[4].statValue = 5;
                playerStats[5].statValue = 5;
                charClass = CharacterClass.Paladin;
                break;
            case 7:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 20;
                playerStats[2].statValue = 5;
                playerStats[3].statValue = 10;
                playerStats[4].statValue = 10;
                playerStats[5].statValue = 10;
                charClass = CharacterClass.Ranger;
                break;
            case 8:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 15;
                playerStats[2].statValue = 5;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 10;
                playerStats[5].statValue = 10;
                charClass = CharacterClass.Rogue;
                break;
            case 9:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 5;
                playerStats[2].statValue = 5;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 15;
                playerStats[5].statValue = 15;
                charClass = CharacterClass.Sorcerer;
                break;
            case 10:
                playerStats[0].statValue = 10;
                playerStats[1].statValue = 5;
                playerStats[2].statValue = 5;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 15;
                playerStats[5].statValue = 10;
                charClass = CharacterClass.Warlock;
                break;
            case 11:
                playerStats[0].statValue = 5;
                playerStats[1].statValue = 5;
                playerStats[2].statValue = 5;
                playerStats[3].statValue = 15;
                playerStats[4].statValue = 15;
                playerStats[5].statValue = 15;
                charClass = CharacterClass.Wizard;
                break;
        }
    }
}
public enum CharacterClass
{
    Barbarian,
    Bard,
    Cleric,
    Druid,
    Fighter,
    Wizard,
    Warlock,
    Sorcerer,
    Monk,
    Paladin,
    Ranger,
    Rogue
}

public enum StatType
{
    Strength,
    Dexterity,
    Etc
}