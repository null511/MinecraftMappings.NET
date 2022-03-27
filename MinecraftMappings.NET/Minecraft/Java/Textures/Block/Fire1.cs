using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Fire1 : JavaBlockTexture
    {
        public Fire1() : base("Fire 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("fire_1")
                .WithDefaultModel<Java.Models.Block.Fire_Floor1>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Fire1>();
        }
    }
}
