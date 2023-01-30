using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public Text coinValue;
    public Slider HpValue;
    public Slider EnergyValue;
    void Update()
    {
        coinValue.text = player.PlayerGold.ToString();
        HpValue.value = Player.PlayerHp;
        EnergyValue.value = Player.PlayerEnergy;
    }
}
