using OmniMod.Items.Consumable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmniMod.Items.Placeable{

    public class OmniBlock : ModItem{

        public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 100;
			ItemID.Sets.ExtractinatorMode[Item.type] = Item.type;


			// DisplayName.AddTranslation(GameCulture.German, "Beispielblock");
			// Tooltip.AddTranslation(GameCulture.German, "Dies ist ein modded Block");
			
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.OmniBlock>());
			Item.width = 12;
			Item.height = 12;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {

			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.DirtBlock, 4);
			recipe1.AddTile(TileID.WorkBenches);
			recipe1.Register();

			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.WoodPlatform, 10);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.Register();
		}

		public override void ExtractinatorUse(int extractinatorBlockType, ref int resultType, ref int resultStack) { // Calls upon use of an extractinator. Below is the chance you will get ExampleOre from the extractinator.
			if (Main.rand.NextBool(3)) {
				resultType = ModContent.ItemType<DefenseBuffPotion>();  // Get this from the extractinator with a 1 in 3 chance.
				if (Main.rand.NextBool(5)) {
					resultStack += Main.rand.Next(2); // Add a chance to get more than one of ExampleOre from the extractinator.
				}


    }
        }}}

