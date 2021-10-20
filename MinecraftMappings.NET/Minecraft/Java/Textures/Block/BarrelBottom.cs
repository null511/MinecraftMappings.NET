using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelBottom : JavaBlockTexture
    {
        public BarrelBottom() : base("Barrel Bottom")
        {
            AddVersion("barrel_bottom")
                .WithMinVersion(new GameVersion(1, 14))
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelBottom>();
        }
    }
}
