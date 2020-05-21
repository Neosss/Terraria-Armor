using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework; //Importante hay que importar las librerias de XNA y terraria si no habra errores
using Terraria;

namespace ArmaduraChingona.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ArmaduraChingona : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Armadura Chingona"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Una armadura para que chingues");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 +=20; //No estoy muy seguro de que esto realmente este furulando, deberia dar un bono de Mana pero no parece reflejarse

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}