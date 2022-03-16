using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cow
{
    public class Cow_RedMooshroom : JavaEntityTexture
    {
        public Cow_RedMooshroom() : base("Red Mooshroom")
        {
            AddVersion("red_mooshroom")
                .WithPath("entity/cow")
                .WithDefaultModel<Java.Models.Entity.Cow>();
                //.MapsToBedrockEntity<BedrockEntities.Cow_RedMooshroom>();
        }
    }
}
