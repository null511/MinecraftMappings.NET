using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JukeboxTop : JavaBlockTexture
    {
        public JukeboxTop() : base("Jukebox Top")
        {
            AddVersion("jukebox_top");
                //.WithDefaultModel<Java.Models.Block.Jukebox>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.JukeboxTop>();
        }
    }
}
