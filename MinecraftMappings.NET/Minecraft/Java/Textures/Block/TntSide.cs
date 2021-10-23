using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TntSide : JavaBlockTexture
    {
        public TntSide() : base("TNT Side")
        {
            AddVersion("tnt_side")
                .WithDefaultModel<Java.Models.Block.Tnt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TntSide>();
        }
    }
}
