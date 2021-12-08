using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeConcretePowder : JavaBlockTexture
    {
        public LimeConcretePowder() : base("Lime Concrete Powder")
        {
            AddVersion("lime_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderLime>();
        }
    }
}
