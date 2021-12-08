using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueConcretePowder : JavaBlockTexture
    {
        public LightBlueConcretePowder() : base("Light Blue Concrete Powder")
        {
            AddVersion("light_blue_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderLightBlue>();
        }
    }
}
