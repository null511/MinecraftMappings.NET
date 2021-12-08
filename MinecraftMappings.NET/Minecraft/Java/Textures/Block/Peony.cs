using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Peony : JavaBlockTexture
    {
        public Peony() : base("Peony")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("peony");
                //.WithDefaultModel<Java.Models.Block.Peony>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerPeony>();
        }
    }
}
