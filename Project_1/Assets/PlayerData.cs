﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
   public WeaponData weapon;
   public FloatData health;
   public ClothesData pants;
   public ClothesData shirt;
   public List<WeaponData> weapons;
   
   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);
      var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      newSprite.color = color;
   }
}
