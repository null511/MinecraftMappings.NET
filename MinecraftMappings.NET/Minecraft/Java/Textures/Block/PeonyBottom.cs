using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PeonyBottom : JavaBlockTexture
    {
        public PeonyBottom() : base("Peony Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("peony_bottom")
                .WithDefaultModel<Java.Models.Block.PeonyBottom>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerPeonyBottom>();
        }
    }
}
