using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Repeater : JavaBlockTexture
    {
        public Repeater() : base("Repeater")
        {
            AddVersion("repeater")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Repeater_4Tick>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Repeater>();
        }
    }
}
