using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LodestoneSide : JavaBlockTexture
    {
        public LodestoneSide() : base("Lodestone Side")
        {
            AddVersion("lodestone_side")
                .WithDefaultModel<Java.Models.Block.Lodestone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LodestoneSide>();
        }
    }
}
