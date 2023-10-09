using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OmniMod.Items.Armor{
    [AutoloadEquip(EquipType.Body)]
    public class ThomysBrust : ModItem {
        public static int MaxManaIncrease = 60;
		public static int MaxMinionIncrease = 4;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MaxManaIncrease, MaxMinionIncrease);

		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
			Item.rare = ItemRarityID.Green; // The rarity of the item
			Item.defense = 6; // The amount of defense the item will give when equipped
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true; // Make the player immune to Fire
			player.statManaMax2 += MaxManaIncrease; // Increase how many mana points the player can have by 20
			player.maxMinions += MaxMinionIncrease; // Increase how many minions the player can have by one
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

    }
}