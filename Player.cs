using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins = 0;
    public AudioSource audiosource;
    public AudioClip coinSound;
    public AudioClip takeDamage;

    public void ChangeCoins(int count_coins)
    {
        audiosource.PlayOneShot(coinSound);
        coins += count_coins;
        print("Кол-во монеток:" + coins);
    }
}
