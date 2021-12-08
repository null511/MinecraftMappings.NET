using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ExposedCutCopper : JavaBlockTexture
    {
        public ExposedCutCopper() : base("Exposed Cut Copper")
        {
            AddVersion("exposed_cut_copper");
                //.WithDefaultModel<Java.Models.Block.ExposedCutCopper>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ExposedCutCopper>();
        }
    }
}
