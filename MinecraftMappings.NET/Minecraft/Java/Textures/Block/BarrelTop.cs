using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelTop : JavaBlockTexture
    {
        public BarrelTop() : base("Barrel, Top")
        {
            AddVersion("barrel_top")
                .WithMinVersion(new GameVersion(1, 14))
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelTop>();
        }
    }
}
