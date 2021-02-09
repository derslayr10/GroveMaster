using KinematicCharacterController;
using R2API;
using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace GroveMaster.Helpers
{
    class PrefabHandler
    {

        public static GameObject bodyPrefab;
        public static GameObject masterPrefab;

        public static void InitiatePrefab() {
        
            PrefabHandler.bodyPrefab = PrefabAPI.InstantiateClone(Resources.Load<GameObject>("prefabs/characterbodies/GravekeeperBody.prefab"), "GroveMasterBody", true, "", "");
            Object.Destroy(PrefabHandler.bodyPrefab.GetComponent<SetStateOnHurt>());
            CharacterBody component = PrefabHandler.bodyPrefab.GetComponent<CharacterBody>();
            component.name = "GroveMasterBossBody";
            component.baseNameToken = "GROVEMASTER_BOSS_BODY_NAME";
            component.subtitleNameToken = "GROVEMASTER_BOSS_BODY_SUBTITLE";
            component.baseMoveSpeed = 10f;
            component.baseMaxHealth = 4500f;
            component.levelMaxHealth = 650f;
            component.baseDamage = 16f;
            component.levelDamage = 8f;
            component.isChampion = true;
            component.portraitIcon = Resources.Load<Sprite>("textures/bodyicons/GravekeeperBody.png").texture;
            PrefabHandler.bodyPrefab.GetComponent<SfxLocator>().deathSound = "GroveMasterDeath";
            PrefabHandler.bodyPrefab.GetComponent<ModelLocator>().modelBaseTransform.gameObject.transform.localScale *= 2.0f;
            foreach (KinematicCharacterMotor kinematicCharacterMotor in bodyPrefab.GetComponentsInChildren<KinematicCharacterMotor>())
            {

                kinematicCharacterMotor.SetCapsuleDimensions(kinematicCharacterMotor.Capsule.radius * 2.0f, kinematicCharacterMotor.Capsule.height * 2.0f, 2.0f);
            
            }
            CharacterModel componentInChildren = PrefabHandler.bodyPrefab.GetComponentInChildren<CharacterModel>();
            Material material = Object.Instantiate<Material>(componentInChildren.baseRendererInfos[0].defaultMaterial);
            material.SetTexture("_MainTex", Resources.Load<Material>("materials/matEliteLightning.mat").GetTexture("_MainTex"));
            material.SetTexture("_EmTex", Resources.Load<Material>("materials/matEliteLightning.mat").GetTexture("_EmissionMap"));
            material.SetFloat("_EmPower", 40f);
            componentInChildren.baseRendererInfos[0].defaultMaterial = material;
            CharacterModel.RendererInfo[] baseRendererInfos = componentInChildren.baseRendererInfos;

            PrefabHandler.masterPrefab = PrefabAPI.InstantiateClone(Resources.Load<GameObject>("prefabs/characterbodies/GravekeeperBody.prefab"), "GrovemasterBossMaster", true, "", "");
            CharacterMaster component2 = PrefabHandler.masterPrefab.GetComponent<CharacterMaster>();
            component2.bodyPrefab = PrefabHandler.bodyPrefab;
            component2.isBoss = true;
            BodyCatalog.getAdditionalEntries += delegate (List<GameObject> list)
            {

                list.Add(PrefabHandler.bodyPrefab);

            };
            MasterCatalog.getAdditionalEntries += delegate (List<GameObject> list)
            {

                list.Add(PrefabHandler.masterPrefab);

            };

        }

    }
}
