using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BarrelTop : BedrockBlockData
    {
        public BarrelTop() : base("Barrel Top")
        {
            AddVersion("barrel_top")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelTop>();
        }
    }
}
