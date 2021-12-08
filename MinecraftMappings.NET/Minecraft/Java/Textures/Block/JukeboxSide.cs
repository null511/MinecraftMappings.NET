using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JukeboxSide : JavaBlockTexture
    {
        public JukeboxSide() : base("Jukebox Side")
        {
            AddVersion("jukebox_side");
                //.WithDefaultModel<Java.Models.Block.Jukebox>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.JukeboxSide>();
        }
    }
}
