using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Turtle
{
    public class BigSeaTurtle : JavaEntityTexture
    {
        public BigSeaTurtle() : base("BigSeaTurtle")
        {
            AddVersion("big_sea_turtle")
                .WithPath("entity/turtle")
                .WithDefaultModel<Java.Models.Entity.Turtle>();
                //.MapsToBedrockEntity<BedrockEntities.BigSeaTurtle>();
        }
    }
}
