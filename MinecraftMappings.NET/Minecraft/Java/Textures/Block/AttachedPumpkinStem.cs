using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AttachedPumpkinStem : JavaBlockTexture
    {
        public AttachedPumpkinStem() : base("Attached Pumpkin Stem")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("attached_pumpkin_stem")
                .WithDefaultModel<Java.Models.Block.AttachedPumpkinStem>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PumpkinStemConnected>();
        }
    }
}
