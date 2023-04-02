using UnityEngine;

namespace WineSim.Items
{
    [CreateAssetMenu(fileName = "Wine", menuName = "Wines/Make New Wine", order = 0)]

    public class Wine : ScriptableObject
    {
       public VarietalEnum varietal;
       public OriginEnum origin;
       public ColorEnum color;
    
    }
}
