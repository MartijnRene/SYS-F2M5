using System;
using System.Collections.Generic;
using System.Text;

namespace Les_2
{
    class Enemy
    {
        public float enemyHealth = 50;
        public float enemySpeed = 3;
        public float enemyDamage = 2;

        public void TakeDamage(float damageTaken)
        {
            enemyHealth -= damageTaken;
        }
    }
}
