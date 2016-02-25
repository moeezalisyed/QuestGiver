using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hero : MonoBehaviour {


    //The three hero fields we discussed for this class - the variable names should be relatively self explanitory

    private int numWins;
    private int experienceLevel;
    private int heroClass;

    //Optional list of quests for a hero
    private List<Quest> quests;


    // Here we initialize the above variables and require an integer representation of "class" to be
    //passed as a parameter

	void init (int Class) {
        this.numWins = 0;
        this.experienceLevel = 0;
        this.heroClass = Class;
        this.quests = new List<Quest>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    //General getters/setters for the parameters
    void addXP(int XP)
    {
        this.experienceLevel += XP;
    }

    int getXP()
    {
        return this.experienceLevel;
    }

    int getWins()
    {
        return this.numWins;
    }

    void addQuest(Quest q)
    {
        this.quests.Add(q);
    }


}
