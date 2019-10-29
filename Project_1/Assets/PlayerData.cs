﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
   public UnityAction<GameObject
   public WeaponData weapon;
   public FloatData health;
   public ClothesData pants;
   public ClothesData shirt;
   public List<WeaponData> weapons;
   
   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);
      var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      playerSprite.sprite = sprite;
      playerSprite.color = spriteColor;
      instanceAction(newPlayer);
   }
}
