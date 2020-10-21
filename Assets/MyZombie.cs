using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyZombie : MonoBehaviour
{
    public ZombieData m_Data;

    public int m_Hp;

    // Start is called before the first frame update
    void Start()
    {
        m_Hp = m_Data.Hp;
    }

    private void OnDestroy()
    {
        m_Data.Hp = m_Hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
