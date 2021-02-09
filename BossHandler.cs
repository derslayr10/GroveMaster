using BepInEx;
using R2API;
using RoR2;
using RoR2.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GroveMaster.Helpers
{
    class BossHandler
    {

        public static CharacterSpawnCard bossSpawner;

        public void CreateBossSpawncard() {

            BossHandler.bossSpawner = ScriptableObject.CreateInstance <CharacterSpawnCard>();
            BossHandler.bossSpawner.name = "cscGroveMaster";
            BossHandler.bossSpawner.prefab = PrefabHandler.masterPrefab;
            BossHandler.bossSpawner.sendOverNetwork = true;
            BossHandler.bossSpawner.hullSize = HullClassification.BeetleQueen;
            BossHandler.bossSpawner.nodeGraphType = MapNodeGroup.GraphType.Ground;
            BossHandler.bossSpawner.requiredFlags = NodeFlags.None;
            BossHandler.bossSpawner.forbiddenFlags = NodeFlags.TeleporterOK;
            BossHandler.bossSpawner.directorCreditCost = 800;
            BossHandler.bossSpawner.occupyPosition = false;
            BossHandler.bossSpawner.loadout = new SerializableLoadout();
            BossHandler.bossSpawner.noElites = false;
            BossHandler.bossSpawner.forbiddenAsBoss = false;

        }

        public void CreateBossFight() {

            ScriptedCombatEncounter encounter = new ScriptedCombatEncounter();

        
        }

    }
}
