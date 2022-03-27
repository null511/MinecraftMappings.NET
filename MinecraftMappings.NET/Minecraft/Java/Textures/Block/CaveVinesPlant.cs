using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CaveVinesPlant : JavaBlockTexture
    {
        public CaveVinesPlant() : base("Cave Vines, Plant")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cave_vines_plant")
                .WithDefaultModel<Java.Models.Block.CaveVines_Plant>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CaveVines>();
        }
    }
}
