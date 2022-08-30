//7/9/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorBehaviour : MonoBehaviour
{
    private List<string> General = new List<string>() {"Racing","FPS","Adventure","Deck Builder","Rogue-Like","Platformer",
                                                       "Strategy","Horror","Survival","Tower Defense","Stealth","Puzzle","Arcade Style",
                                                       "RPG","Sports","Open World","Simulation", "Narrative Based","Maze","Rage Game","Crafting",
                                                       "Word Game","Typing","Idle","Building","Metroidvania","Visual Novel","Endless Runner","Rhythm",
                                                       "Hack and Slash","Fighting", "Reflex Based","Relaxing","Walking Simulator","Bullet Hell",
                                                       "Tycoon","Turn Based","Mini-Games","Point and Click","Collecting","Action","co-operative",
                                                       "Historical","Spy","Motorcycle","Robot","Cartographer","Fishing","Crime","Underwater","Flying",
                                                       "Space","Fantasy","Cyberpunk","Biopunk","Steampunk","Sci-fi","Forest","Post-Apocolyptic",
                                                       "Pre-Apocolyptic","Dystopian","Lumberjack","Happy","Dinosaur","Friend", "Animal", "Zombie","Arena",
                                                       "Boss Based","Train","Trucker","Western","Mystery","Viking","Knight","Samurai","Ninja","Pirate",
                                                       "Farming","Camping","Death","Cooking","Utopian","Lighthouse","Bartender","Hospital","Time Travel",
                                                       "Politics","Slice of Life","Cult","Baking","Digging/Mining","Medic","Moving","Shipping", 
                                                       "Mailman","News","Military","Ghost","Supernatural","Rock and Roll", "Alternate History","Hiking",
                                                       "Wizard","Magic","Travel","Pinball","Insect","Cleaning","Trading","Game Show","Dancing",
                                                       "Small Business", "Big Business","Paperwork","Witch","Library","Dungeon Crawler","Natural Disaster",
                                                       "Street Performer","Golf","Kaiju","Haircut","Battle Royale","Party","Coffee Shop","Psychological",
                                                       "Vampire"};

    private List<string> Constraints = new List<string>() {"be on a mobile device", "be 3D", "be 2D", "be VR", "use controllers", "have animals", "be tabletop", "use a book",
                                                           "be linear", "have multiple endings", "not be able to move", "focus on quality over quantity", 
                                                           "focus on quantity over quality","have robots","not use weapons", "be non visual(text based)",
                                                           "have no words or sounds","be playable only once","be played through mail","have stamina system",
                                                           "have player classes","have different play styles","integrate music into gameplay","not use wasd or arrows to move",
                                                           "have customizable characters","be turn based", "have jump scares","have math equations", "have no words", 
                                                           "have no sounds"};

    private Text Word1;
    private Text Word2;
    private Text MustText;
    private Toggle KeepWord1;
    private Toggle KeepWord2;
    private InputField NewWordField;

    // Start is called before the first frame update
    void Start()
    {
        Word1 = GameObject.Find("Word1").GetComponent<Text>();
        Word2 = GameObject.Find("Word2").GetComponent<Text>();
        MustText = GameObject.Find("Must Text").GetComponent<Text>();
        KeepWord1 = GameObject.Find("KeepWord1").GetComponent<Toggle>();
        KeepWord2 = GameObject.Find("KeepWord2").GetComponent<Toggle>();
        NewWordField = GameObject.Find("NextWordField").GetComponent<InputField>();
        GenerateBasicIdea();
        GenerateConstraint();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitTool(); 
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void GenerateBasicIdea()
    {
        string word1Start = General[Random.Range(0, General.Count)];
        string word2Start = General[Random.Range(0, General.Count)];
        while(word1Start.Equals(word2Start))
        {
            word2Start = General[Random.Range(0, General.Count)];
        }
        if(!KeepWord1.isOn)
        {
            Word1.text = word1Start;
        }
        if(!KeepWord2.isOn)
        {
            Word2.text = word2Start;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void GenerateConstraint()
    {
        string word = Constraints[Random.Range(0, Constraints.Count)];
        while(word.Equals(MustText.text))
        {
            word = Constraints[Random.Range(0, Constraints.Count)];
        }
        MustText.text = word;
    }

    /// <summary>
    /// 
    /// </summary>
    public void RemoveConstraint()
    {
        MustText.text = "";
    }
    /// <summary>
    /// 
    /// </summary>
    public void AddNewWord()
    {
        //MAKE THIS PERMANENT BY ADDING PLAYERPREFS
        if (!General.Contains(NewWordField.text))
        {
            General.Add(NewWordField.text);
            NewWordField.text = "";
        }
        else
        {
            NewWordField.text = "DUPLICATE";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void RemoveWord()
    {
        //MAKE THIS PERMANENT BY ADDING PLAYERPREFS
        if (General.Contains(NewWordField.text))
        {
            General.Remove(NewWordField.text);
            NewWordField.text = "";
        }
        if (Constraints.Contains(NewWordField.text))
        {
            Constraints.Remove(NewWordField.text);
            NewWordField.text = "";
        }
        //ELSE
    }
    /// <summary>
    /// 
    /// </summary>
    public void AddMustWord()
    {
        //MAKE THIS PERMANENT BY ADDING PLAYERPREFS
        if (!Constraints.Contains(NewWordField.text))
        {
            Constraints.Add(NewWordField.text);
            NewWordField.text = "";
        }
        else
        {
            NewWordField.text = "DUPLICATE";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void QuitTool()
    {
        Application.Quit();
    }

}

