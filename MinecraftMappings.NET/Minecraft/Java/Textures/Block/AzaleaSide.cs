using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzaleaSide : JavaBlockTexture
    {
        public AzaleaSide() : base("Azalea Side")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "azalea_side")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.Azalea>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzalea>();
        }
    }
}
