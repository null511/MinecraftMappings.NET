using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzaleaPlant : JavaBlockTexture
    {
        public AzaleaPlant() : base("Azalea Plant")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "azalea_plant")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.Azalea>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzalea>();
        }
    }
}
