using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Fire0 : JavaBlockTexture
    {
        public Fire0() : base("Fire 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("fire_0")
                .WithDefaultModel<Java.Models.Block.Fire_Floor0>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Fire0>();
        }
    }
}
