using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteConcretePowder : JavaBlockTexture
    {
        public WhiteConcretePowder() : base("White Concrete Powder")
        {
            AddVersion("white_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderWhite>();
        }
    }
}
