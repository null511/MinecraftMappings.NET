using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowConcretePowder : JavaBlockTexture
    {
        public YellowConcretePowder() : base("Yellow Concrete Powder")
        {
            AddVersion("yellow_concrete_powder")
                .WithMinVersion("1.12")
                .WithDefaultModel<Java.Models.Block.YellowConcretePowder>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderYellow>();
        }
    }
}
