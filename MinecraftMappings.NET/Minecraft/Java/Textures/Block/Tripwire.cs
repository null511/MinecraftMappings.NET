using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Tripwire : JavaBlockTexture
    {
        public Tripwire() : base("Tripwire")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tripwire")
                .WithDefaultModel<Java.Models.Block.TripwireN>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TripWire>();
        }
    }
}
