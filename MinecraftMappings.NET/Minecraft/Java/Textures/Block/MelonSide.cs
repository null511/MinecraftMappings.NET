using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MelonSide : JavaBlockTexture
    {
        public MelonSide() : base("Melon Side")
        {
            AddVersion("melon_side")
                .WithDefaultModel<Java.Models.Block.Melon>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MelonSide>();
        }
    }
}
