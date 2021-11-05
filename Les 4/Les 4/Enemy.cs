using System;
using System.Collections.Generic;
using System.Text;

namespace Les_4
{
    class Enemy
    {
        public float enemyHealth = 50;
        public float enemyDamage = 3;
        public float enemySpeed = 2;

        public void TakeDamage(float damageTaken)
        {
            enemyHealth -= damageTaken;
        }

        public void Logic()
        {

        }
    }
}
