using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cow
{
    public class RedMooshroom : JavaEntityTexture
    {
        public RedMooshroom() : base("Red Mooshroom")
        {
            AddVersion("red_mooshroom")
                .WithPath("entity/cow")
                .WithDefaultModel<Java.Models.Entity.Cow>();
                //.MapsToBedrockEntity<BedrockEntities.RedMooshroom>();
        }
    }
}
