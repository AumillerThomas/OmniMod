using Omni.Players.Npc;
using OmniMod.Players;
using OmniMod.Players.Npc;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
namespace OmniMod.Buffs{

    public class DefenseBuff : ModBuff{

		private float mSpeed = 1.95f;
		private int lRegen = 10;
		private int mBrath = 500;
		private int brath = 900;
       public static readonly int DefenseBonus = 50;

		public override LocalizedText Description => base.Description.WithFormatArgs(DefenseBonus);

		public override void Update(Player player, ref int buffIndex) {
			player.statDefense += DefenseBonus; // Grant a +10 defense boost to the player while the buff is active.
			player.lifeRegen	+= 	lRegen;
			player.moveSpeed 	+= 	mSpeed;
			player.breathMax 	+= 	mBrath;
			player.breath    	+= 	brath;
			player.findTreasure = true;
		}

    }
}