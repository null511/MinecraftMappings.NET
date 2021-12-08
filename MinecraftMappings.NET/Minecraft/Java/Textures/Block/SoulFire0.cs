using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulFire0 : JavaBlockTexture
    {
        public SoulFire0() : base("Soul Fire 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("soul_fire_0");
                //.WithDefaultModel<Java.Models.Block.SoulFire0>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SoulFire0>();
        }
    }
}
