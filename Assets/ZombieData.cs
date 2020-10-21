﻿using UnityEngine;



[CreateAssetMenu(fileName = "ZombieDB", menuName = "Shader/Zombie Data", order = int.MaxValue)]
public class ZombieData : ScriptableObject
{
    [SerializeField]
    private string zombieName;
    public string ZombieName { get { return zombieName; } }

    [SerializeField]
    private int hp;

    public int Hp { get { return hp; } set { hp = value; } }

    [SerializeField]

    private int damage;

    public int Damage { get { return damage; } }

    [SerializeField]

    private float sightRange;

    public float SightRange { get { return sightRange; } }

    [SerializeField]

    private float moveSpeed;

    public float MoveSpeed { get { return moveSpeed; } }

}
