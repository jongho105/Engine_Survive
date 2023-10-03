using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DTG
{
    public class MainGame : MonoBehaviour
    {
        public void Awake()
        {
            Debug.Log($"Generate Project_Survive!");
        }
    }
}

namespace T_CharacterJob
{
    public enum T_CharacterJob
    {
        Fighter, // 전사
        Archer, // 궁수
        Mage, // 마법사
        Holyknight, // 성기사
    }
}









