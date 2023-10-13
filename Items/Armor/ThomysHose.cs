using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace OmniMod.Items.Armor{
    [AutoloadEquip(EquipType.Legs)]
public class ThomysHose : ModItem{
    public static readonly int MoveSpeedBonus = 5;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedBonus);

		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
			Item.rare = ItemRarityID.Green; // The rarity of the item
			Item.defense = 5; // The amount of defense the item will give when equipped
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += MoveSpeedBonus / 100f; // Increase the movement speed of the player
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 6);
			recipe.AddTile<Tiles.OmniBench>();
			recipe.Register();
		}
	}
}