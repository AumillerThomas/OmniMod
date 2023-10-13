using Omni.Players.Npc;
using OmniMod.Players;
using OmniMod.Players.Npc;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
namespace OmniMod.Buffs{

    public class DefenseBuff : ModBuff{


        public const int DefenseReductionPercent = 25;
		public static float DefenseMultiplier = 1 - DefenseReductionPercent / 100f;

		public override void SetStaticDefaults() {
			Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.

			// Our BuffImmuneGlobalNPC class changes some buff immunity logic. NPCs immune to Ichor will automatically be immune to this buff.
			BuffImmuneGlobalNPC.SetDefenseDebuffStaticDefaults(Type);
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<DamageModificationGlobalNPC>().exampleDefenseDebuff = true; 
		}

		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<DamageModificationPlayer>().exampleDefenseDebuff = true;
			player.statDefense *= DefenseMultiplier;
		}
        
    }
}