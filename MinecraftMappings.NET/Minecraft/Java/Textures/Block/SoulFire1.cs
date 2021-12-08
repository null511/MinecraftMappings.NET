using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulFire1 : JavaBlockTexture
    {
        public SoulFire1() : base("Soul Fire 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("soul_fire_1");
                //.WithDefaultModel<Java.Models.Block.SoulFire1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SoulFire1>();
        }
    }
}
