using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Farmland : JavaBlockTexture
    {
        public Farmland() : base("Farmland")
        {
            AddVersion("farmland")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Farmland>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FarmlandDry>();
        }
    }
}
