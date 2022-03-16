using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cow
{
    public class Cow_BrownMooshroom : JavaEntityTexture
    {
        public Cow_BrownMooshroom() : base("Brown Mooshroom")
        {
            AddVersion("brown_mooshroom")
                .WithPath("entity/cow")
                .WithDefaultModel<Java.Models.Entity.Cow>();
                //.MapsToBedrockEntity<BedrockEntities.Cow_BrownMooshroom>();
        }
    }
}
