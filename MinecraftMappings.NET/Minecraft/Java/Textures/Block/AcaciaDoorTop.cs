using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoorTop : JavaBlockTexture
    {
        public AcaciaDoorTop() : base("Acacia Door, Top")
        {
            AddVersion("acacia_door_top")
                .WithDefaultModel<Java.Models.Block.AcaciaDoorTop>()
                .MapsToBedrockBlock<BedrockBlocks.DoorAcaciaUpper>();
        }
    }
}
