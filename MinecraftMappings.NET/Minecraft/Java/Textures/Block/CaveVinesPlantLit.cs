using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CaveVinesPlantLit : JavaBlockTexture
    {
        public CaveVinesPlantLit() : base("Cave Vines, Plant Lit")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cave_vines_plant_lit")
                .WithDefaultModel<Java.Models.Block.CaveVines_PlantLit>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CaveVines>();
        }
    }
}
