using Terraria.ID;
using Terraria.ModLoader;

namespace minecraft_items.Items
{
	public class bow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bow");
			Tooltip.SetDefault("This is a modded bow.");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 20;
            item.pick = 100;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 7.0f;
            item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cobweb, 3);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
