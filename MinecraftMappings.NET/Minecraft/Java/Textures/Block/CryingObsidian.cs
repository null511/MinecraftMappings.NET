using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CryingObsidian : JavaBlockTexture
    {
        public CryingObsidian() : base("Crying Obsidian")
        {
            AddVersion("crying_obsidian");
                //.WithDefaultModel<Java.Models.Block.CryingObsidian>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CryingObsidian>();
        }
    }
}
