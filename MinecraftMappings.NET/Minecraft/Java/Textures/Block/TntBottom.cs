using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TntBottom : JavaBlockTexture
    {
        public TntBottom() : base("TNT Bottom")
        {
            AddVersion("tnt_bottom")
                .WithDefaultModel<Java.Models.Block.Tnt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TntBottom>();
        }
    }
}
