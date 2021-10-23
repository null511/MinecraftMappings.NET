using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cow
{
    public class BrownMooshroom : JavaEntityTexture
    {
        public BrownMooshroom() : base("Brown Mooshroom")
        {
            AddVersion("brown_mooshroom")
                .WithPath("entity/cow")
                .WithDefaultModel<Java.Models.Entity.Cow>();
                //.MapsToBedrockEntity<BedrockEntities.BrownMooshroom>();
        }
    }
}
