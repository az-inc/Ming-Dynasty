using UnityEngine;
using System.Collections;

namespace Player
{
    //Developed by DevCardude
    public class PlayerObject
    {
        public int playerID; //Created for multiplayer perposes. A value of 0-100, inclusive.
        public bool[] playerIDReg = new bool[100]; //Created for multiplayer purposes. returns true if playerid inputed is taken
        public decimal[] health = new decimal[100]; //self explained
        public bool[] isMing = new bool[100]; //self explained
        public bool[] isMale = new bool[100]; //self explained
        public decimal[] mana = new decimal[100]; //only Ming. like ammo
        public decimal[] shield = new decimal[100]; //like extra set of health that can be recovered over time. both sides have this.
        public decimal[] energy = new decimal[100]; //like ammo
        public int[] charges = new int[100]; //like clips
        public decimal[] stamina = new decimal[100]; //for things like sprinting
        public int[] level = new int[100]; //both sides
        public decimal[] experience = new decimal[100]; //both sides
        public int[] skillpoints = new int[100]; //used in skilltree. both sides
        public int[] coins = new int[100]; //Mingling currency
        public decimal[] credits = new decimal[100]; //UFP currency

        //Finds an open PlayerID to use, return as int
        public int findOpenId()
        {
            Player.PlayerObject foo = new Player.PlayerObject();
            for (int i = 1; i <= 100; i++)
            {
                if (foo.playerIDReg[i] == false)
                {
                    return i;
                }
            }
            return 999;
        }

        //required for init: playerID, isMing, isMale
        public void PlayerObjInit(int playerIdIn, bool isMingIn, bool isMaleIn)
        {
            playerID = playerIdIn;
            isMing[playerID] = isMingIn;
            isMale[playerID] = isMaleIn;
            playerIDReg[playerID] = true;
        }

        //required for all: health, sheild, stanima, level, experience, skillpoints
        //Ming required stats: mana, coins
        public void PlayerStatsMing(int playerIDIn, decimal healthIn, decimal shieldIn, decimal manaIn,
            decimal stanimaIn, int coinsIn, int levelIn, int experienceIn, int skillpointsIn)
        {
            if (isMing[playerIDIn] = false) { }
            else
            {
                health[playerIDIn] = healthIn;
                shield[playerIDIn] = shieldIn;
                stamina[playerIDIn] = stanimaIn;

                level[playerIDIn] = levelIn;
                experience[playerIDIn] = experienceIn;
                skillpoints[playerIDIn] = skillpointsIn;

                mana[playerIDIn] = manaIn;
                coins[playerIDIn] = coinsIn;
            }
        }

        //required for all: health, sheild, stanima, level, experience, skillpoints
        //UFP required stats: energy, charges, credits
        public void PlayerStatsUFP(int playerIDIn, decimal healthIn, decimal shieldIn, decimal energyIn, int chargesIn,
            decimal stanimaIn, decimal creditsIn, int levelIn, int experienceIn, int skillpointsIn)
        {
            if (isMing[playerIDIn] = true) { }
            else
            {
                health[playerIDIn] = healthIn;
                shield[playerIDIn] = shieldIn;
                stamina[playerIDIn] = stanimaIn;

                level[playerIDIn] = levelIn;
                experience[playerIDIn] = experienceIn;
                skillpoints[playerIDIn] = skillpointsIn;

                credits[playerIDIn] = creditsIn;
                energy[playerIDIn] = energyIn;
                charges[playerIDIn] = chargesIn;
            }
        }

        public void removePlayerID(int playerIDIn)
        {
            Player.PlayerObject foo = new Player.PlayerObject();
            foo.playerIDReg[playerIDIn] = false;
            foo.isMale[playerIDIn] = false;
            foo.isMing[playerIDIn] = false;

            foo.health[playerIDIn] = 0;
            foo.shield[playerIDIn] = 0;
            foo.stamina[playerIDIn] = 0;
            foo.mana[playerIDIn] = 0;

            foo.level[playerIDIn] = 0;
            foo.experience[playerIDIn] = 0;
            foo.skillpoints[playerIDIn] = 0;

            foo.credits[playerIDIn] = 0;
            foo.coins[playerIDIn] = 0;

            foo.charges[playerIDIn] = 0;
            foo.energy[playerIDIn] = 0;

        }

        public class Position
        {
            public decimal[] X = new decimal[100];
            public decimal[] Y = new decimal[100];
            public decimal[] Z = new decimal[100];
        }
    }
}