using Terraria.ID;
using Terraria.ModLoader;

namespace minecraft_items.Items
{
	public class golden_sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("golden sword");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 80;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
