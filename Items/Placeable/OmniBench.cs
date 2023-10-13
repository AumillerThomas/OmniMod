using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmniMod.Items.Placeable{

    public class OmniBench : ModItem {

        public override void SetDefaults() {
			// ModContent.TileType<Tiles.Furniture.ExampleWorkbench>() retrieves the id of the tile that this item should place when used.
			// DefaultToPlaceableTile handles setting various Item values that placeable items use
			// Hover over DefaultToPlaceableTile in Visual Studio to read the documentation!
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.OmniBench>());
			Item.width = 28; // The item texture's width
			Item.height = 14; // The item texture's height
			Item.value = 150;
		}

        public override void AddRecipes() {

			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

    }

}