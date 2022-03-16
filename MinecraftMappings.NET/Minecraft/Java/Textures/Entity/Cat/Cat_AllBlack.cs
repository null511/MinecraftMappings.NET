using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_AllBlack : JavaEntityTexture
    {
        public Cat_AllBlack() : base("Cat, All Black")
        {
            AddVersion("all_black")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_AllBlack>();
        }
    }
}
