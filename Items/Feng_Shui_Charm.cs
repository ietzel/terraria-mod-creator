using Terraria.ID;
using Terraria.ModLoader;

namespace terraria_feng_shui_enneagram_mod.Items {
	public class FengShuiCharm : ModItem {
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Adds 20 bonuses based around Feng Shui.");
		}
		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("ExampleMod:ExampleItem");
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
		}
	}
}
