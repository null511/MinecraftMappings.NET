using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelTop : JavaBlockTexture
    {
        public BarrelTop() : base("Barrel, Top")
        {
            AddVersion(4, "barrel_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelTop>();
        }
    }
}
