using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
   public List<WeaponData> collectionList;

   public void AddData(GameArtData obj)
   {
      collectionList.Add(obj);
      {
         if (!obj.collected)
         {
            collectionList.Add(obj);
            obj.collected = true;
         }
      }
   }
}
