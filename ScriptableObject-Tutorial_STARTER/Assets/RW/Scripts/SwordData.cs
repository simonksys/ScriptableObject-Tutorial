using UnityEngine;

/// <summary>
/// 所有剑的数据
/// </summary>

[CreateAssetMenu(fileName = "New SwordData",menuName = "SwordData",order = 51)]
public class SwordData : ScriptableObject
{
   [SerializeField] private string swordName; //名称
   [SerializeField] private string description;//描述
   [SerializeField] private Sprite icon;//图标
   [SerializeField] private int goldCost;//花费金币
   [SerializeField] private int attackDamage;//攻击伤害

   
   /// <summary>
   /// getter 以便其它脚本能访问到SO里边的数据
   /// 下边写法等同于 get方法
   /// puvlic string SwordName{get{return swordName;}}
   /// </summary>
   public string SwordName => swordName;
   public string Description => description;
   public Sprite Icon => icon;
   public int GoldCost => goldCost;
   public int AttackDamage => attackDamage;
}
