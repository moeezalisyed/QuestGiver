using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest : MonoBehaviour {

    //Constant (immutable) variables representing time availability of this quest.

    public const int LIMITEDAVAIL = 1;

    public const int ANYTIME = 0;

    //Previous and next quest in chain, used for linked list style implementation of quest chains

    private Quest previous;

    private Quest next;

    //Boolean value for whether or not this quest is the final in a chain

    private bool isFinalInChain;

    //Ints for quest time,


    private int QuestType, TimeNeeded, reqLevel, reqXP;

    //List of integer represeentations of the required classes

    private List<int> reqClasses;

	/*
    Init for Quest object, takes in the numerical values listed in the design doc aas parameters
    to instantiate the above fields.
    */
	void init(int questType, int TimeNeeded, int reqLevel, int reqXP, List<int> reqClasses, List<Quest> previousAndNextList) {
        this.TimeNeeded = TimeNeeded;
        this.reqLevel = reqLevel;
        this.reqXP = reqXP;
        this.reqClasses = reqClasses;

        //If the quest is limited availability, we want to set its previous quest as specified by the parameter

        if (questType == LIMITEDAVAIL)
        {
            this.QuestType = questType;
            this.previous = previousAndNextList[0];

            //Now, we can infer the isFinalInChain value by checking if the second value of
            //previousAndNextList is null. If it is, the value is true, false otherwise.

            if (previousAndNextList[1] == null)
            {
                this.isFinalInChain = true;
            }
            else
            {
                this.isFinalInChain = false;
            }
        }
        else
        {

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
