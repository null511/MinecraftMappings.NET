using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DirtPathTop : JavaBlockTexture
    {
        public DirtPathTop() : base("Dirt Path Top")
        {
            AddVersion("dirt_path_top")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.DirtPath>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathTop>();
        }
    }
}
