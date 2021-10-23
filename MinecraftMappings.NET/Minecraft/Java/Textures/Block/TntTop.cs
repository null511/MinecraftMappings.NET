using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TntTop : JavaBlockTexture
    {
        public TntTop() : base("TNT Top")
        {
            AddVersion("tnt_top")
                .WithDefaultModel<Java.Models.Block.Tnt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TntTop>();
        }
    }
}
