using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RoseBushTop : JavaBlockTexture
    {
        public RoseBushTop() : base("Rose Bush Top")
        {
            AddVersion("rose_bush_top")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.RoseBushTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_RoseTop>();
        }
    }
}
