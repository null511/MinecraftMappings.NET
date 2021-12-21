using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleDoorTop : JavaBlockTexture
    {
        public JungleDoorTop() : base("Jungle Door Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("jungle_door_top")
                .WithDefaultModel<Java.Models.Block.JungleDoorTop>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorJungleUpper>();
        }
    }
}
