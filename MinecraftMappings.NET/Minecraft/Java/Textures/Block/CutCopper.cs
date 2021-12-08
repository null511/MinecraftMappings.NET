using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CutCopper : JavaBlockTexture
    {
        public CutCopper() : base("Cut Copper")
        {
            AddVersion("cut_copper");
                //.WithDefaultModel<Java.Models.Block.CryingObsidian>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CryingObsidian>();
        }
    }
}
