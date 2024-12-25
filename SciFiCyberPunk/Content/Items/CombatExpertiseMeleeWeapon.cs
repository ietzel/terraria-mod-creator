using System.Random;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SciFiCyberPunk.Content.Items { 
	public class CombatExpertiseMeleeWeapon : ModItem {
		public override void SetDefaults() {
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			Random r = new Random();
			int rIntOneA = r.Next(1, 21);
			int rIntOneB = r.Next(1, 21);
			if(rIntOneA + 5 >= rIntOneB) {
				target.AddBuff(BuffID.Bleeding, 5*60);
			}
			int rIntTwoA = r.Next(1, 21);
			int rIntTwoB = r.Next(1, 21);
			if(rIntTwoA + 5 >= rIntTwoB) {
				target.AddBuff(BuffID.Poisoned, 5*60);
			}
			int rIntThreeA = r.Next(1, 21);
			int rIntThreeB = r.Next(1, 21);
			if(rIntThreeA + 5 >= rIntThreeB) {
				target.AddBuff(BuffID.OnFire, 5*60);
			}
			int rIntFourA = r.Next(1, 21);
			int rIntFourB = r.Next(1, 21);
			if(rIntFourA + 5 >= rIntFourB) {
				target.AddBuff(BuffID.Slow, 5*60);
			}
			int rIntFiveA = r.Next(1, 21);
			int rIntFiveB = r.Next(1, 21);
			if(rIntFiveA + 5 >= rIntFiveB) {
				target.AddBuff(BuffID.BrokenArmor, 5*60);
			}
        }
	}
}
