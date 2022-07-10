using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            GenerateBasicIdea();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateBasicIdea()
    {
        string word1 = General[Random.Range(0, General.Count)];
        string word2 = General[Random.Range(0, General.Count)];
        while(word1.Equals(word2))
        {
            word2 = General[Random.Range(0, General.Count)];
        }
    }
    public void AddNewWord()
    {

    }

    private bool HasDuplicate()
    {
        return false;
    }
}

