using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_SO", menuName = "Data/PlayerData")]
public class PlayerData_SO : ScriptableObject
{
    [Header("角色数据")]
    [Header("ID与头像")]
    public string playerName;
    public Sprite playerIcon;
    public Sprite playerOnWorldSprite;
    public string playerDescription;

    [Header("基础数据")]
    [Header("营养,初始为5000")]
    [Range(0,5000)]public int playerNutrition;//营养
    [Header("疲劳，初始为0")]
    [Range(0,2000)]public int playerTired;//疲劳
    [Header("情绪，初始为0")]
    [Range(-500,500)] public int playerEmotion;//情绪
    [Header("压力，初始为0")]
    [Range(0, 1000)] public int playerPressure;//压力
    [Header("疼痛，初始为0")]
    [Range(0, 200)] public int playerPain;//疼痛
    [Header("信心，初始为0")]
    [Range(-500,500)] public int playerConfidence;//信心
    [Header("专注，初始为5000")]
    [Range(0, 5000)] public int playerConcentration;//专注
    [Header("魅力，初始为0")]
    [Range(0, 5000)] public int playerCharm;//魅力
    [Header("魅惑，初始为0")]
    [Range(0, 5000)] public int playerGlamour;//魅惑
    [Header("高潮，初始为0")]
    [Range(0, 1000)] public int playerClimax;//高潮

    [Header("角色状态")]
    [Header("疲劳状态，睡眠-250/h，休息-150/10min，清醒+1/min，运动（另算）")]
    public FatigueStateType fatigueStateType;

    public bool isDead;
    public bool attackable;
    public bool removable;
    public bool invincible;
}
