using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_SO", menuName = "Data/PlayerData")]
public class PlayerData_SO : ScriptableObject
{
    [Header("角色数据")]
    [Header("ID与头像")]
    public int playerID;
    public string playerName;
    public Sprite playerIcon;
    public Sprite playerOnWorldSprite;
    public string playerDescription;

    [Header("基础数据")]
    public int playerHp;
    public float playerSpeed;
    public int playerDamage;
    public float playerAttackCD;

    [Header("角色状态")]
    public bool isDead;
    public bool attackable;
    public bool removable;
    public bool invincible;
}
