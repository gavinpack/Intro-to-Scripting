using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
   public List<WeaponData> collectionList;

   public void AddData(GameArtData obj)
   {
      if (!collectionList.Contains(obj))
      {
         collectionList.Add(obj);
      }
   }

   public void RemoveLastItem()
   {
      if (!collectionList.Contains(null))
      {
         collectionList.RemoveAt(index: collectionList.Count -1);
      }
   }
}
