using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeConcretePowder : JavaBlockTexture
    {
        public OrangeConcretePowder() : base("Orange Concrete Powder")
        {
            AddVersion("orange_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderOrange>();
        }
    }
}
