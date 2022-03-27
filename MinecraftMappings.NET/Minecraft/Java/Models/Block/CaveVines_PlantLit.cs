using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CaveVines_PlantLit : JavaBlockModel
    {
        public CaveVines_PlantLit() : base("Cave Vines, Plant Lit")
        {
            AddVersion("cave_vines_plant_lit", "1.5")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cave_vines_plant_lit");
        }
    }
}
